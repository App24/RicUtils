using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("RicUtils.Editor")]
namespace RicUtils
{
    internal static class PathConstants
    {
        public const string SCRIPTABLES_FOLDER = "ScriptableObjects";

        public const string RICUTILS_FOLDER = "RicUtils";

        public const string EDITOR_FOLDER = "Editor";

        public const string ASSETS_FOLDER = "Assets";

        public const string RESOURCES_FOLDER = "Resources";

        public const string MANAGERS_DATA_FOLDER = "Managers Data";
        public const string MANAGERS_DATA_PATH = ASSETS_FOLDER + "/" + SCRIPTABLES_FOLDER + "/" + MANAGERS_DATA_FOLDER;

        public const string EDITOR_SETTINGS_PATH = ASSETS_FOLDER + "/" + RICUTILS_FOLDER + "/" + RESOURCES_FOLDER + "/" + EDITOR_FOLDER;
        public const string RUNTIME_SETTINGS_PATH = ASSETS_FOLDER + "/" + RICUTILS_FOLDER + "/" + RESOURCES_FOLDER;

        public const string EDITOR_SETTINGS_FILE_PATH = EDITOR_FOLDER + "/" + EDITOR_SETTINGS_NAME;
        public const string EDITOR_SETTINGS_NAME = "RicUtils_Editor_Settings";

        public const string RUNTIME_SETTINGS_FILE_PATH = RUNTIME_SETTINGS_NAME;
        public const string RUNTIME_SETTINGS_NAME = "RicUtils_Settings";

        public const string AVAILABLES_FOLDER = ASSETS_FOLDER + "/" + SCRIPTABLES_FOLDER + "/" + RESOURCES_FOLDER + "/" + RESOURCES_AVAILABLES_FOLDER;
        public const string RESOURCES_AVAILABLES_FOLDER = "Availables";

        public const string TEMPLATES_PATH = ASSETS_FOLDER + "/" + RICUTILS_FOLDER + "/" + EDITOR_FOLDER + "/" + TEMPLATES_FOLDER;
        public const string TEMPLATES_FOLDER = "Templates";
    }
}
