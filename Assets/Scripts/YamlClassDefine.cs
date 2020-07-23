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
    public AnimatedTile m_AnimatedTiles { get; set; }
    public List<TileAsset> m_TileAssetArray { get; set; }
    public List<TileAsset> m_TileSpriteArray { get; set; }

    public List<TileMatrix> m_TileMatrixArray { get; set; }

    public List<TileColorElement> m_TileColorArray { get; set; }
    public int[] m_TileObjectToInstantiateArray { get; set; }
    public int m_AnimationFrameRate { get; set; }
    public ColorData m_Color;
    public PositionData m_Origin { get; set; }
    public SizeData m_Size { get; set; }
    public PositionData m_TileAnchor { get; set; }
    public int m_TileOrientation { get; set; }
    public TileMatrixData m_TileOrientationMatrix { get; set; }
}
public class SizeData
{
    public int x { get; set; }
    public int y { get; set; }
    public int z { get; set; }
}

public class PositionData
{
    public float x { get; set; }
    public float y { get; set; }
    public float z { get; set; }
}
public class ColorData
{
    public float r { get; set; }
    public float g { get; set; }
    public float b { get; set; }
    public float a { get; set; }
}
public class TileColorElement
{
    public int m_RefCount { get; set; }
    public ColorData m_Data { get; set; }
}
public class TileMatrix
{
    public int m_RefCount { get; set; }
    public TileMatrixData m_Data { get; set; }
}
public class TileMatrixData
{
    public int e00 { get; set; }
    public int e01 { get; set; }
    public int e02 { get; set; }
    public int e03 { get; set; }
    public int e10 { get; set; }
    public int e11 { get; set; }
    public int e12 { get; set; }
    public int e13 { get; set; }
    public int e20 { get; set; }
    public int e21 { get; set; }
    public int e22 { get; set; }
    public int e23 { get; set; }
    public int e30 { get; set; }
    public int e31 { get; set; }
    public int e32 { get; set; }
    public int e33 { get; set; }
}
public class AnimatedTile
{

}
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