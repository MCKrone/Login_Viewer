using System.Collections.Generic;
using System.IO;

namespace Workplace_Viewer
{
    public class UseXML
    {
        private string path;
        private TmpInfo infos;

        public UseXML()
        {
            infos = TmpInfo.Instance;
            loadXML();
        }

        private void loadXML()
        {
            List<string> settings = infos.SettingValues;

            path = $"{settings[2]}:\\{settings[3]}";
            //path = Directory.GetCurrentDirectory() + "\\XML_Files\\logins_save.xml";
        }      
        
        public Logins getLoginObjects()
        {
            Serializer ser = new Serializer();
            string xmlInputData = string.Empty;
            
            xmlInputData = File.ReadAllText(path);
            
            return ser.Deserialize<Logins>(xmlInputData); ;
        }  

        public void saveLoginObjects()
        {
            Serializer ser = new Serializer();
            string xmlOutputData = string.Empty;

            Logins logs = new Logins();
            logs.LoginList = infos.LoginList;
            logs.VersionNo = infos.CurrentVersion;

            xmlOutputData = ser.Serialize<Logins>(logs);
            File.WriteAllText(path, xmlOutputData);
        }        
    }
}
