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
}
//}

public class PrefabTileSet
{
    public TilemapData Tilemap { get; set; }
}