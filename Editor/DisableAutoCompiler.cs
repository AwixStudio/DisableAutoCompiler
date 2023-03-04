using UnityEditor;
using UnityEngine;

public class DisableAutoCompiler
{
    [MenuItem("Tools/Auto Compiler/Toggle")]
    public static void Toggle()
    {
        int status = EditorPrefs.GetInt("kAutoRefresh");
        if (status == 1)
        {
            EditorPrefs.SetInt("kAutoRefresh", 0);
            Debug.Log("Auto script recompile is disabled");
        }
        else
        {
            EditorPrefs.SetInt("kAutoRefresh", 1);
            Debug.Log("Auto script recompile is enabled");
        }
    }
}
