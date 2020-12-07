using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Resources.classes
{
    static class DBconfigs
    {
        private static string Host = "127.0.0.1";
        private static string Port = "3306";
        private static string Username = "root";
        private static string Pass = "";
        private static string Database = "gamebookdata";
        public static string ConnectionString { get => $"datasource={Host};port={Port};username={Username};password={Pass};database={Database};"; }
    }
}
