using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System;
using UnityEngine.Tilemaps;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.RepresentationModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;

public class LoadTimeMap : MonoBehaviour
{
    public string TileMapPath;
    public string SpriteDataPath;
    public Sprite_MultiRes SpriteBuildData;
    private CustomYamlClass.Rootobject m_rootDataTsx;
    private tileset m_tileSet;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    [ContextMenu("DeserializeSpriteYaml")]
    public void DeserializeSpriteYaml()
    {
        string strFinal = UtilFile.ReadStringFromFile(SpriteDataPath);
        strFinal = strFinal.Replace("213", "V213");
        var input = new StringReader(strFinal);

        var deserializer = new DeserializerBuilder()
            .WithNamingConvention(new NullNamingConvention())
            .Build();

        m_rootDataTsx = deserializer.Deserialize<CustomYamlClass.Rootobject>(input);
        int a = 0;
    }

    [ContextMenu("LoadFileTest")]
    public void LoadFile()
    {
        try
        {
            string str = UtilFile.ReadStringFromFile(TileMapPath);
            //string strReplace = str.Replace("---", "aaa");
            int nStartIdx = str.IndexOf("Tilemap", 0);
            int nEndIdx = str.IndexOf("---", nStartIdx);
            string strTileMapPaletteData = str.Substring(nStartIdx, nEndIdx - nStartIdx);
            string strFinal = strTileMapPaletteData;

            var input = new StringReader(strFinal);

            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(new NullNamingConvention())
                .Build();

            var tileSetDataIns = deserializer.Deserialize<PrefabTileSet>(input);

            Debug.Log(str);
        }
        catch (FileNotFoundException e)
        {
            Debug.Log(e.ToString());
        }
    }
    [ContextMenu("LoadSpriteData")]
    public void LoadSpriteData()
    {
        try
        {
            string str = UtilFile.ReadStringFromFile(SpriteDataPath);
            string strReplace = str.Replace("213", "V213");

            int nIdxExternal = strReplace.IndexOf("externalObjects");
            if(nIdxExternal > 0)
            {
                strReplace = strReplace.Substring(0, nIdxExternal);
            }
            var input = new StringReader(strReplace);

            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(new NullNamingConvention())
                .Build();

            SpriteBuildData = deserializer.Deserialize<Sprite_MultiRes>(input);

        }
        catch (SerializationException e)
        {
            int nres = e.ToString().IndexOf("externalObjects");
            if (nres >= 0)
            {
                int a = 0;
            }
        }
        catch (FileNotFoundException e)
        {
            Debug.Log(e.ToString());
        }
    }
    [ContextMenu("XmlSerializeData")]
    private void XmlSerializeData()
    {
        map mapData = new map();
        mapTileset tileset = new mapTileset();
        tileset.firstgid = 1;
        tileset.source = "baba.tsx";
        mapData.tileset = tileset;

        mapLayer mapLayerIns = new mapLayer();
        mapLayerIns.id = 1;
        mapLayerIns.name = "Tile Layer 1";
        mapLayerIns.width = 5;
        mapLayerIns.height = 6;
        mapLayerData dataField = new mapLayerData();
        dataField.encoding = "csv";
        dataField.Value = @"1, 2, 3, 4, 5, 
7, 8, 9, 10, 11, 
13, 14, 15, 16, 17, 
19, 20, 21, 22, 23, 
25, 26, 27, 28, 29, 
31, 32, 33, 34, 35";
        mapLayerIns.data = dataField;
        mapData.layer = mapLayerIns;

        //< map version = "1.2" tiledversion = "1.3.1" orientation = "orthogonal" renderorder = "right-down" compressionlevel = "-1" width = "5" height = "6" tilewidth = "16" tileheight = "16" infinite = "0" nextlayerid = "2" nextobjectid = "1" >
        mapData.version = 1.2m;
        mapData.tiledversion = "1.3.1";
        mapData.orientation = "orthogonal";
        mapData.renderorder = "right-down";
        mapData.compressionlevel = -1;
        mapData.width = 5;
        mapData.height = 6;
        mapData.tilewidth = 16;
        mapData.tileheight = 16;
        mapData.infinite = 0;
        mapData.nextlayerid = 2;
        mapData.nextobjectid = 1;


        XmlSerializer serializer = new XmlSerializer(mapData.GetType());
        StreamWriter writer = new StreamWriter("test.tmx");
        serializer.Serialize(writer.BaseStream, mapData);
        writer.Close();
    }
    public tileset GetTileSet()
    {
        return m_tileSet;
    }
    [ContextMenu("TsxSerializeData")]
    public void TsxSerializeData()
    {
        DeserializeSpriteYaml();
        m_tileSet = new tileset();

        int nMaxRow = 0;
        int nMaxColumn = 0;
        foreach(CustomYamlClass.Sprite _spr in m_rootDataTsx.TextureImporter.spriteSheet.sprites)
        {
            m_tileSet.tilewidth = (byte)_spr.rect.width;
            m_tileSet.tileheight = (byte)_spr.rect.height;
            int nCol = _spr.rect.x / m_tileSet.tilewidth;
            if( nMaxColumn < nCol )
            {
                nMaxColumn = nCol;
            }
            int nRow = _spr.rect.y / m_tileSet.tileheight;
            if (nMaxRow < nRow)
            {
                nMaxRow = nRow;
            }
        }
        nMaxColumn++;
        nMaxRow++;
        m_tileSet.columns = (byte)nMaxColumn;
        m_tileSet.tilecount = (byte)(nMaxColumn * nMaxRow);
        m_tileSet.version = 1.2m;
        m_tileSet.tiledversion = "1.3.1";
        m_tileSet.name = "baba";
        tilesetImage _img = new tilesetImage();
        _img.height = (byte)(nMaxColumn * m_tileSet.tileheight);
        _img.width = (byte)(nMaxRow * m_tileSet.tilewidth);
        _img.source = "Assets/Resources/Sprites/SmallPalette.png";
        m_tileSet.image = _img;

        _serializeTsx(m_tileSet,"test.tsx");
        XmlSerializer serializer = new XmlSerializer(m_tileSet.GetType());
        StreamWriter writer = new StreamWriter("test.tsx");
        serializer.Serialize(writer.BaseStream, m_tileSet);
        writer.Close();
    }
    private void _serializeTsx(tileset _tileSet,string strFileName)
    {
        XmlSerializer serializer = new XmlSerializer(_tileSet.GetType());
        StreamWriter writer = new StreamWriter("test.tsx");
        serializer.Serialize(writer.BaseStream, _tileSet);
        writer.Close();
    }
    private void JsonSerialize()
    {

        //TestOrder _order = new TestOrder();
        //_order.TestTest = new TilemapData();
        //_order.TestTest.m_ObjectHideFlags = 15;
        //_order.TestTest.dda = new FileIDData();
        //_order.TestTest.dda.fileID = "file";
        //_order.TestTest.dda.guid = "file";
        //_order.TestTest.dda.type = "file";
        //var serializer = new SerializerBuilder().Build();
        //var yaml = serializer.Serialize(_order);
    }
}
