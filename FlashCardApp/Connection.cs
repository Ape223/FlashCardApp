using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Identity.Client;
using System.Reflection;
using System.IO;
namespace FlashCardApp
{
    internal class Connection
        //
    {
        public SqlConnection connection = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public string location = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\hlu98\Desktop\FlashCardApp (1)\FlashCardApp\Users.mdf; Integrated Security = True";
        //https://www.youtube.com/watch?v=_S-LacqE7OM
    }
}
