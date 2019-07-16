using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace CleverPoppy
{
    public class dbClass
    {
        public static string getString()
        {
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# projects\C# project\CleverPoppy\Database\LoginDB.mdf;Integrated Security=True;Connect Timeout=30";
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CleverPoppy.Properties.Settings.LoginDBConnectionString"].ConnectionString;
            return connectionString;
            
        }
    }
}
