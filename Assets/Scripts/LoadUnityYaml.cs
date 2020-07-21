using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadUnityYaml : MonoBehaviour
{
    public string YamlFileName;
    // Start is called before the first frame update
    void Start()
    {
        string strContent = FileUtil.GetFileContextByPath(YamlFileName);
        int a = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
