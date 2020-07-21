using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class UtilFile 
{
    public static string ReadStringFromFile(string strPath)
    {
        StreamReader reader = new StreamReader(strPath);
        string strRet = reader.ReadToEnd();
        reader.Close();
        return strRet;
    }
}
