using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Figo
{
    public static class FigoAsset
    {
        public static TAsset[] FindAssets<TAsset>(string filter, params string[] searchInFolder) where TAsset : Object
        {
            List<TAsset> assets = new List<TAsset>();
            var guids = UnityEditor.AssetDatabase.FindAssets(filter, searchInFolder);
            foreach (var g in guids)
            {
                var p = UnityEditor.AssetDatabase.GUIDToAssetPath(g);
                assets.Add(UnityEditor.AssetDatabase.LoadAssetAtPath<TAsset>(p));
            }
            return assets.ToArray();
        }
    }
}