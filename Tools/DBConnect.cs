using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace Kursovik.Tools
{
    static class DBConnect
    {
        public static string connect = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={GetDBPath()};Integrated Security=True;Connect Timeout=30";
    
        public static string GetDBPath()
        {
            string path = "";
            if (File.Exists("../../kursovik.mdf"))
            {
                path = Path.GetFullPath("../../kursovik.mdf");
            }
            else
            {
                MessageBox.Show("Database not found");
            }
            return path;
        }
    }
}
