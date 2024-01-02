using System.IO;
using UnityEditor;
using UnityEngine;

public class ExportAssetBundles
{
    [MenuItem("AssetBundles/Build")]
    static void ExportResource()
    {
        string folderName = "AssetBundles";
        string filePath = Path.Combine(Application.streamingAssetsPath, folderName);

        //Build for Windows platform
        BuildPipeline.BuildAssetBundles(filePath, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows64);

        //Refresh the Project folder
        AssetDatabase.Refresh();
    }
}