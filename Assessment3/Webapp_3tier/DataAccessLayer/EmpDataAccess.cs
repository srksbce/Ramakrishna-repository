using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class EmpDataAccess
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6EOHVMA\\SQLEXPRESS;Initial Catalog=snadDB;Integrated Security=True");
        public DataSet GetData(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}
