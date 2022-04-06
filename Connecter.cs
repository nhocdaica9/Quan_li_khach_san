using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    class Connecter
    {
        public SqlConnection connecting()
        {
            string connectionString = "Server=localhost\\SQLEXPRESS01;Database=master;Trusted_Connection=True;User ID=nhocdaica9;Password=duy1782002";
            return new SqlConnection(connectionString);
        }
    }
}
