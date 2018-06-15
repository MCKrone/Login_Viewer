using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Login_Viewer
{
    class EditListView
    {
        private TmpInfo infos;

        public EditListView()
        {
            infos = TmpInfo.Instance;
        }

        public ListViewItem findItemByName(ListView view, string name)
        {
            ListViewItem item = null;

            ListViewItem[] items = view.Items.Find(name, false);
            if(items.Length > 0)
            {
                item = items[0];
            }

            return item;
        }

        public void addGroups(ListView[] views)
        {
            List<GroupObject> groups = new List<GroupObject>(infos.ListGroups);

            groups.Sort((x, y) => x.IndexAz.CompareTo(y.IndexAz));

            foreach (ListView view in views)
            {           
                foreach (GroupObject group in groups)
                {
                    view.Groups.Add(new ListViewGroup() {
                        Header = group.Name,
                        Name = group.Name
                    });
                }
            }
            
        }

        public void addItem(ListView view, LoginObject log)
        {
            ListViewItem item = createItem(view, log);
            
            view.Items.Add(item);
        }

        public void updateItem(ListView view, LoginObject log)
        {
            ListViewItem item = createItem(view, log);

            int index = view.Items.IndexOfKey(log.ID.ToString());
            if(index > -1)
                view.Items[index] = item;
            else
                view.Items.Add(item);
        }

        public void removeItem(ListView view, string logID)
        {
            int index = view.Items.IndexOfKey(logID);
            if (index > -1)
                view.Items.RemoveAt(index);           
        }

        public ListViewItem createItem(ListView view, LoginObject log)
        {
            return new ListViewItem()
            {
                Name = log.ID.ToString(),
                Text = log.Name,
                ImageIndex = log.Index,
                Group = view.Groups[log.IndexAz]
            };
        }

        public ListViewItem[] addList(ListView view)
        {
            ListViewItem[] logs = infos.LoginList.Select(c => createItem(view, c)).ToArray();

            return logs;
        }

        public ListViewItem[] addListFav(ListView view)
        {
            ListViewItem[] logs = infos.LoginList.Where(c => c.Fav).Select(c => createItem(view, c)).ToArray();

            return logs;
        }
    }
}
