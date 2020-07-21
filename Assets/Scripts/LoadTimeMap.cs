﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

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
            Debug.Log(str);
        }
        catch (FileNotFoundException e)
        {
            Debug.Log(e.ToString());
        }
    }
}
