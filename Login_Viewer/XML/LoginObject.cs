using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Viewer
{
    public partial class LoginObject
    {
        public Guid ID { get; set; }
        public bool Fav { get; set; }
        public int Index { get; set; }
        public int IndexAz { get; set; }
        public string GroupName { get; set; }
        public string Name { get; set; }
        public string Website { get; set; }
        public string Mail { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Memo { get; set; }       
        public DateTime CreationDate { get; set; } 
        public DateTime ChangeDate { get; set; }
    }
}
