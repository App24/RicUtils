﻿using RicUtils.Editor.Windows;
using RicUtils.ScriptableObjects;
using TypeReferences;

namespace RicUtils.Editor.Settings
{
    [System.Serializable]
    public class ScriptableEditor
    {
        [Inherits(typeof(GenericScriptableObject), ShortName = true, AllowAbstract = false, IncludeBaseType = false, ShowAllTypes = true)]
        public TypeReference customScriptableObjectType;

        [Inherits(typeof(GenericEditorWindow<,>), ShortName = true, AllowAbstract = false, IncludeBaseType = false, ShowAllTypes = true)]
        public TypeReference editorType;

        [Inherits(typeof(AvailableScriptableObject<>), ShortName = true, AllowAbstract = false, IncludeBaseType = false, ShowAllTypes = true)]
        public TypeReference availableScriptableObjectType;

        public System.Type CustomScriptableObjectType => customScriptableObjectType;

        public System.Type EditorType => editorType;

        public System.Type AvailableScriptableObjectType => availableScriptableObjectType;

        public bool IsValid()
        {
            return (CustomScriptableObjectType != null);
        }

        public bool IsSameKeyType(System.Type type)
        {
            if (type == null || CustomScriptableObjectType == null) return false;
            return type == CustomScriptableObjectType || type.IsSubclassOf(CustomScriptableObjectType);
        }

        public bool HasCustomEditor(System.Type type)
        {
            if (!IsSameKeyType(type)) return false;
            return editorType.Type != null;
        }

        public bool HasAvailableScriptableObject(System.Type type)
        {
            if (!IsSameKeyType(type)) return false;
            return availableScriptableObjectType.Type != null;
        }
    }
}
