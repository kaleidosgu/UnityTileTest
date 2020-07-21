using System.Collections;
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
            Debug.Log(str);
        }
        catch (FileNotFoundException e)
        {
            Debug.Log(e.ToString());
        }
    }
}
