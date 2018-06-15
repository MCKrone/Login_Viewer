using Login_Viewer;
using System.Collections.Generic;
using System.Configuration;

namespace Workplace_Viewer
{
    class Settings
    {
        private TmpInfo infos;

        private string[] settingKeys, listGroups;

        public Settings()
        {
            infos = TmpInfo.Instance;

            settingKeys = new string[] { "trueCpath", "trueCfile", "trueCMountDrive", "logXmlPath", "autoMount", "autoDismount", "updateVersion" };
            listGroups = new string[] {
                "Event","Fun","Game & Co","Health","Home","Knowledge",
                "Mail","Management","Mobile","Music","Payment","Service","Shop","Social",
                "Software","Student","Travel","TV & Co","Work", "Food", "TU-DD"
            };
        }        

        public void loadSettings()
        {
            infos.ListGroups = createListGroups();

            List<string> settings = new List<string>();
            var appSettings = ConfigurationManager.AppSettings;

            foreach (string key in settingKeys)
            {
                settings.Add(appSettings[key]);
            }
            infos.SettingValues = settings;
        }

        private List<GroupObject> createListGroups()
        {
            List<GroupObject> groups = new List<GroupObject>();

            int index = 1;
            foreach (string name in listGroups)
            {
                groups.Add(new GroupObject()
                {
                    IndexDef = index,
                    Name = name
                });

                index++;
            }
            groups.Sort((x, y) => x.Name.CompareTo(y.Name));

            groups.Insert(0, new GroupObject()
            {
                Name = "None",
                IndexDef = 0
            });

            for (int i = 0; i < groups.Count; i++)
            {
                groups[i].IndexAz = i;
            }

            return groups;
        }

        public void saveSettings(List<string> changedSettings)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;

            int index = 0;
            foreach (string value in changedSettings)
            {
                infos.SettingValues[index] = value;
                settings[settingKeys[index]].Value = value;
                index++;
            }

            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }        
    }
}
