using Login_Viewer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workplace_Viewer
{
    public sealed class TmpInfo
    {
        private static readonly Lazy<TmpInfo> lazy = new Lazy<TmpInfo>(() => new TmpInfo());

        public static TmpInfo Instance { get { return lazy.Value; } }

        public TmpInfo()
        {
            ListGroups = new List<GroupObject>();
            LoginList = new List<LoginObject>();
            IsMounted = false;
            SettingValues = new List<string>();
        }

        public List<LoginObject> LoginList { get; set; }
        public List<GroupObject> ListGroups { get; set; }
        public bool IsMounted { get; set; }
        public List<string> SettingValues { get; set; }
        public string CurrentVersion { get; set; }
    }
}
