using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Resources.classes
{
    class DBconfigs
    {
        private string Host = "127.0.0.1";
        private string Port = "3306";
        private string Username = "root";
        private string Pass = "";
        private string Database = "gamebookdata";
        public string ConnectionString { get => "datasource=" + Host + ";port=" + Port + ";username=" + Username + ";password=" + Pass + ";database=" + Database + ";";}
    }
}
