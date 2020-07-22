using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Tilemaps;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.RepresentationModel;
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
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
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
            string strFinal = "---\n" + strTileMapPaletteData;
            //            strFinal = @"
            //TestTest:
            //  m_ObjectHideFlags: 15
            //";
            strFinal = @"
  Tilemap:
    m_ObjectHideFlags: 0
    m_CorrespondingSourceObject: {fileID: 0}
    m_PrefabInstance: {fileID: 0}
    m_PrefabAsset: {fileID: 0}
    m_GameObject: {fileID: 2193453691686714506}
    m_Enabled: 1
    m_Tiles:
    - first: {x: -1, y: -10, z: 0}
      second:
        serializedVersion: 2
        m_TileIndex: 246
        m_TileSpriteIndex: 246
        m_TileMatrixIndex: 0
        m_TileColorIndex: 0
        m_TileObjectToInstantiateIndex: 65535
        m_AllTileFlags: 1073741825
    - first: {x: 0, y: -10, z: 0}
      second:
        serializedVersion: 2
        m_TileIndex: 247
        m_TileSpriteIndex: 247
        m_TileMatrixIndex: 0
        m_TileColorIndex: 0
        m_TileObjectToInstantiateIndex: 65535
        m_AllTileFlags: 1073741825
";

            var input = new StringReader(strFinal);

            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(new NullNamingConvention())
                .Build();

            //var stream = new YamlStream();
            //stream.Load(input);

            var order = deserializer.Deserialize<PrefabTileSet>(input);


            Debug.Log(str);
        }
        catch (FileNotFoundException e)
        {
            Debug.Log(e.ToString());
        }
    }
    [ContextMenu("DeserializeData")]
    private void DeserializeData()
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

        int a = 0;
    }
    private void dd()
    {
    //    var stream = new YamlStream();
    //    string input = GetFileContextByPath(strSpriteRelate);
    //    stream.Load(new StringReader(input));

    //    var deserializer = new DeserializerBuilder()
    //.WithNamingConvention(new NullNamingConvention())
    //.Build();

    //    m_sprData = deserializer.Deserialize<SpriteDataClass>(input);
    //    m_sprData.BuildDic();
    //    int a = 0;
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
        int a = 0;
        //output.WriteLine(yaml);
    }
}
