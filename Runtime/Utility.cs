using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.UIElements;
using UnityEngine;

namespace Figo
{
    public static class FigoUtility
    {
        public static TValue Parse<TValue>(this System.Enum value)
        {
            return (TValue)(object)value;
        }
    }
}