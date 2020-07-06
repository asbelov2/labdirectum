namespace Reflection
{
    using System.Configuration;

    /// <summary>
    /// Configuration class
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// Get parameter by name
        /// </summary>
        /// <param name="name">Pereameter's name</param>
        /// <param name="defaultValue">Default value</param>
        /// <returns>Value by name</returns>
        public static string GetAppSettingsValues(string name, string defaultValue)
        {
            string[] tempResults = ConfigurationManager.AppSettings.GetValues(name);
            return ((tempResults != null) && (tempResults.Length > 0) &&
            (!string.IsNullOrEmpty(tempResults[0]))) ? tempResults[0] : defaultValue;
        }

        /// <summary>
        /// SubSetting collection
        /// </summary>
        [ConfigurationCollection(typeof(SubSettingSection),
        CollectionType = ConfigurationElementCollectionType.AddRemoveClearMap)]
        public class SubSettingCollection : ConfigurationElementCollection
        {
            /// <summary>
            /// Creating new subsection
            /// </summary>
            /// <returns>New instance of subsettings</returns>
            protected override ConfigurationElement CreateNewElement()
            {
                return new SubSettingSection();
            }

            /// <summary>
            /// Get element key
            /// </summary>
            /// <param name="element">Element object</param>
            /// <returns>Key of element</returns>
            protected override object GetElementKey(ConfigurationElement element)
            {
                return ((SubSettingSection)element).SubSetting;
            }
        }

        /// <summary>
        /// Program settings section
        /// </summary>
        public class SettingsSection : ConfigurationSection
        {
            /// <summary>
            /// IntSetting parameter
            /// </summary>
            [ConfigurationProperty("IntSetting", IsRequired = true)]
            public int IntSetting
            { 
                get { return (int)this["IntSetting"]; }
            }

            /// <summary>
            /// StrSetting parameter
            /// </summary>
            [ConfigurationProperty("StrSetting", IsRequired = true)]
            public string StrSetting
            {
                get { return this["StrSetting"].ToString(); }
            }

            /// <summary>
            /// All subsettings
            /// </summary>
            [ConfigurationProperty("", IsDefaultCollection = true, IsRequired = true)]
            public SubSettingCollection SubSettings
            {
                get { return (SubSettingCollection)this[string.Empty]; }
            }
        }

        /// <summary>
        /// SubSetting section
        /// </summary>
        internal class SubSettingSection : ConfigurationElement
        {
            /// <summary>
            /// SubSetting key
            /// </summary>
            [ConfigurationProperty("SubSetting", IsRequired = true, IsKey = true)]
            public string SubSetting
            {
                get { return (string)this["SubSetting"]; }
            }

            /// <summary>
            /// SubSetting value
            /// </summary>
            [ConfigurationProperty("SubSettingValue", IsRequired = true)]
            public string SubSettingValue
            {
                get { return (string)this["SubSettingValue"]; }
            }
        }
    }
}
