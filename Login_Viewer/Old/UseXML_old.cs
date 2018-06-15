using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Login_Viewer
{
    class UseXML_old
    {
        private XmlDocument doc;
        private XmlNode root;
        private XmlNodeList nodeList;
        private string path;
        //private TmpInfo infos;

        public void loadXML()
        {
            //List<string> settings = infos.SettingValues;

            // path = $"{settings[2]}:\\{settings[3]}";
            path = Application.StartupPath + "\\XML_Files\\logins_save.xml";

            doc = new XmlDocument();
            doc.Load(path);

            root = doc.DocumentElement;
        }

        public List<string> getLogins()
        {
            List<string> logins = new List<string>();

            nodeList = root.SelectNodes("//logins/*");

            foreach (XmlNode node in nodeList)
            {
                logins.Add(node.FirstChild.InnerText);
            }

            logins.Sort();

            return logins;
        }
        public List<string> getContent(string name)
        {
            XmlNode loginNode = getLoginNode(name);

            return readNode(loginNode);
        }

        private XmlNode getLoginNode(string name)
        {
            string path = "//login[name = \"" + name + "\"]";
            return root.SelectSingleNode(path);
        }

        private List<string> readNode(XmlNode loginNode)
        {
            List<string> content = new List<string>();

            foreach (XmlNode node in loginNode.ChildNodes)
            {
                if (node.HasChildNodes && node.ChildNodes[0].HasChildNodes)
                {
                    foreach (XmlNode childNode in node.ChildNodes)
                    {
                        content.Add(childNode.InnerText);
                    }
                }
                else
                {
                    content.Add(node.InnerText);
                }
            }

            return content;
        }

        public bool saveLogin(string loginName, List<string> changes)
        {
            bool success = true;
            string changeName = changes[0];
            XmlNode loginNode = getLoginNode(loginName);

            if (getLoginNode(changeName) == null || loginName == changeName)
            {
                int index = 0;
                foreach (XmlNode node in loginNode.ChildNodes)
                {
                    if (index <= 4)
                    {
                        node.InnerText = changes[index];
                    }
                    else
                    {
                        XmlNodeList childNodes = node.ChildNodes;

                        int childNoteCount = childNodes.Count;
                        int newChanges = 0;
                        for (int i = 0; i < (changes.Count - 5); i++)
                        {
                            if (i < childNoteCount)
                            {
                                childNodes[i].InnerText = changes[index];
                                newChanges++;
                            }
                            else
                            {
                                XmlElement elem = doc.CreateElement("x");
                                elem.InnerText = changes[index];
                                node.AppendChild(elem);
                            }

                            index++;
                        }

                        if (newChanges < childNoteCount)
                        {
                            for (int i = newChanges; i < childNodes.Count; i++)
                            {
                                node.RemoveChild(childNodes[i]);
                            }
                        }

                    }

                    index++;
                }

                doc.PreserveWhitespace = true;
                doc.Save(path);

                loadXML();
            }
            else
            {
                MessageBox.Show("Name schon vorhanden!\r\nBitte ändern!", "Speichern nicht möglich", MessageBoxButtons.OK, MessageBoxIcon.Error);

                success = false;
            }

            return success;
        }

        public void addLogin()
        {
            XmlNode nodeToCopy = root.SelectSingleNode("//logins/*");
            XmlNode newNode = doc.CreateElement("login");

            newNode.InnerXml = nodeToCopy.InnerXml;

            DateTime t = DateTime.Now;
            string name = "0_" + t.Hour + "_" + t.Minute + "_" + t.Second;

            newNode.FirstChild.InnerText = name;

            doc.DocumentElement.SelectSingleNode("//logins").AppendChild(newNode);

            saveLogin(name, new List<string>() { name, "", "", "", "", "" });
        }

        public bool removeLogin(string loginName)
        {
            bool success = false;

            XmlNode node = getLoginNode(loginName);
            XmlNode parent = node.ParentNode;
            parent.RemoveChild(node);

            doc.Save(path);
            loadXML();
            success = true;

            return success;
        }
    }
}
