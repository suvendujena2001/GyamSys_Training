using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ClinicManagement
{
    internal class ConnectionString
    {
        public SqlConnection GetCon()
        {
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\SubhasisGouda\OneDrive - GyanSys Inc\Documents\form\ClinicManagement\ClinicManagement\DentalCare.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False";
            return Con;
        }
    }
}
