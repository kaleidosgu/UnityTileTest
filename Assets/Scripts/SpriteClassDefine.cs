using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite_MultiRes 
{
    public int fileFormatVersion { get; set; }
    public string guid { get; set; }
    public Sprite_TextureImporter TextureImporter { get; set; }
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
    public string V223 { get; set; }
}
