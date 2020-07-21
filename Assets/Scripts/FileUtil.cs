using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class FileUtil 
{
    public static string GetFileContextByPath(string strPath)
    {
        StreamReader reader = new StreamReader(strPath);
        string str = reader.ReadToEnd();
        reader.Close();
        return str;
    }
}
