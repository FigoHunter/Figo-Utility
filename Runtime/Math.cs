using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Figo
{
    public static class FigoMath
    {
        public static (Vector3 translation, Quaternion rotation, Vector3 Scale) GetTrs(this Matrix4x4 mat)
        {
            var t = new Vector3(mat.m03, mat.m13, mat.m23);
            var r = mat.rotation;
            var s = mat.lossyScale;
            mat = mat * Matrix4x4.Inverse(Matrix4x4.Scale(s)) * Matrix4x4.Inverse(Matrix4x4.Rotate(r));
            return (t, r, s);
        }
    }
}