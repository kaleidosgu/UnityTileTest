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
//using YamlTest;
//using YamlDotNet.Serialization;
//using YamlDotNet.Samples.Helpers;
public class subClass
{
    public subClass()
    {
        babaloka = 5;
    }
    public int babaloka { get; set; }
}
public class TestClass
{
    public int  testInt { get; set; }
    public string testString { get; set; }
    //public Vector2 test { get; set; }
    public subClass ta { get; set; }
    public Dictionary<string,int> _baba { get; set; }
    public List<Dictionary<string, string>> ooo { get; set; }
    //public int[] arrayInt { get; set; }
}

public class LoadTimeMap : MonoBehaviour
{
    public string TileMapPath;
    public string SpriteDataPath;
    public Sprite_MultiRes SpriteBuildData;
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

        var rootObj = deserializer.Deserialize<CustomYamlClass.Rootobject>(input);
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
            //            strFinal = @"
            //TestTest:
            //  m_ObjectHideFlags: 15
            //";
            //            strFinal = @"
            //  Tilemap:
            //    m_ObjectHideFlags: 0
            //    m_CorrespondingSourceObject: {fileID: 0}
            //    m_PrefabInstance: {fileID: 0}
            //    m_PrefabAsset: {fileID: 0}
            //    m_GameObject: {fileID: 2193453691686714506}
            //    m_Enabled: 1
            //    m_Tiles:
            //    - first: {x: -1, y: -10, z: 0}
            //      second:
            //        serializedVersion: 2
            //        m_TileIndex: 246
            //        m_TileSpriteIndex: 246
            //        m_TileMatrixIndex: 0
            //        m_TileColorIndex: 0
            //        m_TileObjectToInstantiateIndex: 65535
            //        m_AllTileFlags: 1073741825
            //    - first: {x: 0, y: -10, z: 0}
            //      second:
            //        serializedVersion: 2
            //        m_TileIndex: 247
            //        m_TileSpriteIndex: 247
            //        m_TileMatrixIndex: 0
            //        m_TileColorIndex: 0
            //        m_TileObjectToInstantiateIndex: 65535
            //        m_AllTileFlags: 1073741825
            //    m_AnimatedTiles: {}
            //    m_TileAssetArray:
            //    - m_RefCount: 1
            //      m_Data: {fileID: 11400000, guid: 0e97bf42273b34c4a87eb122070f2b47, type: 2}
            //    - m_RefCount: 1
            //      m_Data: {fileID: 11400000, guid: bc73fe04d8612de4796b4e2e78d610f9, type: 2}
            //    m_TileSpriteArray:
            //    - m_RefCount: 1
            //      m_Data: {fileID: -8942568313111905122, guid: 05235d4e4f127634fa6805b2b927b801,
            //      type: 3}
            //    - m_RefCount: 1
            //      m_Data: {fileID: -2131922044865327498, guid: 05235d4e4f127634fa6805b2b927b801,
            //      type: 3}
            //";

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
        int a = 0;
    }
    [ContextMenu("TsxSerializeData")]
    public void TsxSerializeData()
    {
        tileset _tileSet = new tileset();

        _tileSet.version = 1.2m;
        _tileSet.tiledversion = "1.3.1";
        _tileSet.name = "baba";
        _tileSet.tilewidth = 16;
        _tileSet.tileheight = 16;
        _tileSet.tilecount = 36;
        _tileSet.columns = 6;
        tilesetImage _img = new tilesetImage();
        _img.height = 96;
        _img.width = 96;
        _img.source = "Assets/Resources/Sprites/SmallPalette.png";
        _tileSet.image = _img;


        XmlSerializer serializer = new XmlSerializer(_tileSet.GetType());
        StreamWriter writer = new StreamWriter("test.tsx");
        serializer.Serialize(writer.BaseStream, _tileSet);
        writer.Close();
    }
    [ContextMenu("TestYaml")]
    public void TestYaml()
    {
        var serializer = new SerializerBuilder().Build();
        TestClass _testIns = new TestClass();
        _testIns.testInt = 15;
        _testIns.testString = "1234";
        _testIns.ta = new subClass();
        _testIns._baba = new Dictionary<string, int>();
        _testIns._baba.Add("0", 15);
        _testIns._baba.Add("1", 25);
        _testIns.ooo = new List<Dictionary<string, string>>();
        Dictionary<string, string> test = new Dictionary<string, string>();
        test.Add("1", "a");
        test.Add("2", "b");
        _testIns.ooo.Add(test);
        test = new Dictionary<string, string>();
        test.Add("3", "c");
        test.Add("4", "d");
        _testIns.ooo.Add(test);
        //_testIns.test = new Vector2(1, 2);
        var yaml = serializer.Serialize(_testIns);
        //output.WriteLine(yaml);

        string[] arrayLines = { };
        UtilFile.ReadFileLines(SpriteDataPath, out arrayLines);

        foreach(string str in arrayLines)
        {

        }
        int a = 0;
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
