using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Figo
{
    public static class FigoPath
    {
        private static IEnumerable<string> Internal_WalkThrough(string path, bool recursive = false, string relative_path = "./")
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            if (dir.Exists)
            {
                foreach (var file in dir.EnumerateFiles())
                {
                    yield return relative_path + file.Name;   
                }
                if (recursive)
                {
                    foreach (var sub in dir.EnumerateDirectories())
                    {
                        foreach (var file in Internal_WalkThrough(sub.FullName, true, relative_path + sub.Name + "/"))
                        {
                            yield return file;
                        }
                    }
                }
            }
        }

        public static IEnumerable<string> WalkThrough(string path, bool recursive = false)
        { 
            return Internal_WalkThrough(path, recursive);
        }
    }
}