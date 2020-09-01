using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Build.Reporting;
using System.Linq;

public class BuildClass : MonoBehaviour
{
    public static void Winx64LZ4HCBuild()
    {
        string[] scenes = EditorBuildSettings.scenes.Where(scene => scene.enabled).Select(s => s.path).ToArray();
        BuildReport buildReport = BuildPipeline.BuildPlayer(scenes, "build/StandaloneWindows64", BuildTarget.StandaloneWindows64, BuildOptions.CompressWithLz4HC);
    }
}
