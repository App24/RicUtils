using RicUtils.Editor.Utilities;
using RicUtils.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace RicUtils.Editor.Toolbar
{
    public static class CreateAvailableScriptableObjects
    {
        [MenuItem("RicUtils/Create Available Scriptable Objects", priority = 1)]
        public static void CreateAvailableScripts()
        {
            foreach (var keyValuePair in ToolUtilities.GetScriptableEditors())
            {
                if (!keyValuePair.IsValid()) continue;
                if (keyValuePair.AvailableScriptableObjectType == null) continue;
                var path = RicUtilities.GetAvailableScriptableObjectPath(keyValuePair.AvailableScriptableObjectType);
                RicUtilities.CreateAssetFolder(path);

                var available = AssetDatabase.LoadAssetAtPath(path, keyValuePair.AvailableScriptableObjectType);
                if (available == null)
                {
                    available = ScriptableObject.CreateInstance(keyValuePair.AvailableScriptableObjectType);
                    var items = (IList)System.Activator.CreateInstance(typeof(List<>).MakeGenericType(keyValuePair.CustomScriptableObjectType));
                    keyValuePair.AvailableScriptableObjectType.GetMethodRecursive("SetItems", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).Invoke(available, new object[] { items });

                    AssetDatabase.CreateAsset(available, path);

                    AssetDatabase.SaveAssets();
                }
            }
        }
    }
}
