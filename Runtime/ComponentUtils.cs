using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Figo
{
    public static class ComponentUtils
    {
        public static TComponent GetOrAddComponent<TComponent>(this GameObject go) where TComponent: Component
        { 
            var comp = go.GetComponent<TComponent>();
            if ( comp == null)
            {
                comp = go.AddComponent<TComponent>();
            }
            return comp;
        }

        public static TComponent GetOrAddComponent<TComponent>(this Component a) where TComponent : Component
        {
            var go = a.gameObject;
            var comp = go.GetComponent<TComponent>();
            if (comp == null)
            {
                comp = go.AddComponent<TComponent>();
            }
            return comp;
        }
    }
}