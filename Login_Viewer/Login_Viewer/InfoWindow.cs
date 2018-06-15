using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My.Collections.Generic;
using Workplace_Viewer;

namespace Login_Viewer
{
    public partial class InfoWindows : Form
    {
        TmpInfo info;

        private string[] columHeaderNames, valueNames;
        private int[] visibleStates, editStates;

        public InfoWindows()
        {
            InitializeComponent();

            info = TmpInfo.Instance;

            columHeaderNames = new string[] { "Name", "Change Type", "Changed", "Created", "Website", "Mail", "Username", "Password", "Memo", "Favorite", "Group", "ID", "Index", "IndexAz"};
            valueNames = new string[] { "Name", "ChangeType", "ChangeDate", "CreationDate", "Website", "Mail", "Username", "Password", "Memo", "Fav", "GroupName", "ID", "Index", "IndexAz" };
            visibleStates = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            editStates = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            FillTreeView();
        }

        private void FillTreeView()
        {
            dataGVChanges.AutoGenerateColumns = true;        
            
            dataGVChanges.DataSource = new SortedBindingList<LoginObject>(info.LoginList);

            dataGVChanges.Columns["Export"].DisplayIndex = 0;

            int indexPlus = 1;

            for (int i = 0; i < columHeaderNames.Length; i++)
            {
                dataGVChanges.Columns[valueNames[i]].HeaderText = columHeaderNames[i];
                dataGVChanges.Columns[valueNames[i]].Visible = visibleStates[i] == 1 ? true : false;
                dataGVChanges.Columns[valueNames[i]].DisplayIndex = i + indexPlus;
                dataGVChanges.Columns[valueNames[i]].ReadOnly = editStates[i] == 1 ? false : true;
                dataGVChanges.Columns[valueNames[i]].SortMode = DataGridViewColumnSortMode.Automatic;
            }

            dataGVChanges.Sort(dataGVChanges.Columns["ChangeDate"], ListSortDirection.Ascending);
            //https://dotnet-snippets.de/snippet/bindinglist-mit-sortierfunktion/1129            
        }        
    }
}