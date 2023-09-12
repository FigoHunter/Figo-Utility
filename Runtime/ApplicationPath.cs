using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Figo
{
    public static class ApplicationPath
    {
        public static string streamingAssetsPath => Application.streamingAssetsPath;
        public static string persistentDataPath => Application.persistentDataPath;
        public static string dataPath => Application.dataPath;

#if UNITY_EDITOR
        public static string projectPath => Application.dataPath.Substring(0,dataPath.Length-"/Assets".Length);
#endif

        public static string ForwardSlash(this string path)
        {
            return path.Replace('\\', '/');
        }
    }
}
