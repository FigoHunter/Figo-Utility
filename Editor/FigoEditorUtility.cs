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
            folder = EditorPrefs.GetString($"OPEN_FOLDER", folder);
            folder = EditorUtility.OpenFolderPanel(title, folder, defaultName);
            if (string.IsNullOrEmpty(folder))
            {
                return folder;
            }
            EditorPrefs.SetString($"OPEN_FOLDER", folder);
            return folder;
        }

        public static string OpenFilePanel(string title, string folder, string extension)
        {
            folder = EditorPrefs.GetString($"OPEN_FILE", folder);
            var file = EditorUtility.OpenFilePanel(title, folder, extension);
            if (string.IsNullOrEmpty(file))
            {
                return file;
            }
            EditorPrefs.SetString($"OPEN_FILE", Path.GetDirectoryName(file));
            return file;
        }
    }
}