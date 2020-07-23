using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite_MultiRes 
{
    public int fileFormatVersion { get; set; }
    public string guid { get; set; }
    public Sprite_TextureImporter TextureImporter { get; set; }

    public int FindIndexOfSpriteName(string strID)
    {
        int nIdx = 0;
        foreach(Sprite_IDToNameTable _element in TextureImporter.internalIDToNameTable)
        {
            nIdx++;
            if (_element.second.Equals(strID) == true)
            {
                break;
            }
        }
        if(nIdx != TextureImporter.internalIDToNameTable.Count - 1)
        {
            return nIdx;
        }
        return -1;
    }
}
public class Sprite_TextureImporter
{
    public List<Sprite_IDToNameTable> internalIDToNameTable { get; set; }
}
public class Sprite_IDToNameTable
{
    public Sprite_IDToNameTable_First first { get; set; }
    public string second { get; set; }
}
public class Sprite_IDToNameTable_First
{
    //213
    public string V213 { get; set; }
}
