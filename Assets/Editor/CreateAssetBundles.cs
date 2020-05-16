using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class CreateAssetBundles
{
    [MenuItem("AssetBundle/Build AssetBundles")]
    static void BuildAllAssetBundle()
    {
        // 打包至StreamingAssets文件夹
        //string streamPath = Application.streamingAssetsPath;

        //string streamPath = Application.dataPath + "/AssetBundleLearn/StreamingAssets/";
         
        string streamPath = "AB";
        if (Directory.Exists(streamPath))
        {

            Directory.Delete(streamPath);
        }

        Directory.CreateDirectory(streamPath);
        AssetDatabase.Refresh();

        //BuildPipeline.BuildAssetBundles(streamPath,BuildAssetBundleOptions.None,BuildTarget.StandaloneWindows64);
        BuildPipeline.BuildAssetBundles(streamPath, BuildAssetBundleOptions.None, BuildTarget.Android);
    }


}
