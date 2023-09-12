using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

namespace Figo
{
    public static class FigoEditorUtility
    {
        public static string OpenFolderPanel(string title, string folder, string defaultName)
        {
            folder = EditorPrefs.GetString($"OPEN_FOLDER_{title}", folder);
            folder = EditorUtility.OpenFolderPanel(title, folder, defaultName);
            if (string.IsNullOrEmpty(folder))
            {
                return folder;
            }
            EditorPrefs.SetString($"OPEN_FOLDER_{title}", folder);
            return folder;
        }

        public static string OpenFilePanel(string title, string folder, string extension)
        {
            folder = EditorPrefs.GetString($"OPEN_FILE_{title}", folder);
            var file = EditorUtility.OpenFilePanel(title, folder, extension);
            if (string.IsNullOrEmpty(file))
            {
                return file;
            }
            EditorPrefs.SetString($"OPEN_FILE_{title}", Path.GetDirectoryName(file));
            return file;
        }
    }
}