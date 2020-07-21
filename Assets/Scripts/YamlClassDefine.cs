using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TileSprite
{
    public string fileID { get; set; }
    public string guid { get; set; }
    public string type { get; set; }

}
//namespace YamlTest
//{
public class testSubClass
{
    public int m_ObjectHideFlags { get; set; }
    public TileSprite dda { get; set; }
}
//}

    public class TestOrder
{
    public testSubClass TestTest { get; set; }
}