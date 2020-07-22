using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FileIDData
{
    public string fileID { get; set; }

}
//namespace YamlTest
//{
public class TilemapData
{
    public int m_ObjectHideFlags { get; set; }
    public FileIDData m_CorrespondingSourceObject { get; set; }
    public FileIDData m_PrefabInstance { get; set; }
    public FileIDData m_PrefabAsset { get; set; }
    public FileIDData m_GameObject { get; set; }
    public int m_Enabled { get; set; }
    public List<TileSetDetail> m_Tiles { get; set; }

    //因为没有现成的数据，所以m_AnimatedTiles暂时定义为int的List
    public List<int> m_AnimatedTiles { get; set; }
    public List<TileAsset> m_TileAssetArray { get; set; }
}
//}

public class PrefabTileSet
{
    public TilemapData Tilemap { get; set; }
}
public class TileSetDetail
{
    public TileSetFirstData first { get; set; }
    public TileSetSecondData second { get; set; }
}
public class TileSetFirstData
{
    public int x { get; set; }
    public int y { get; set; }
    public int z { get; set; }
}
public class TileSetSecondData
{
    public int serializedVersion { get; set; }
    public int m_TileIndex { get; set; }
    public int m_TileSpriteIndex { get; set; }
    public int m_TileMatrixIndex { get; set; }
    public int m_TileColorIndex { get; set; }
    public int m_TileObjectToInstantiateIndex { get; set; }
    public Int64 m_AllTileFlags { get; set; }
}

public class TileAssetData
{
    public string fileID { get; set; }
    public string guid { get; set; }
    public string type { get; set; }
}
public class TileAsset
{
    public int m_RefCount { get; set; }
    public TileAssetData m_Data { get; set; }
}