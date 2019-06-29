using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_KetNoi
    {
        protected SqlConnection con = new SqlConnection("Data Source=DESKTOP-9Q03V1M\\SQLEXPRESS;Initial Catalog=QL_QuanCafe;Integrated Security=True");
        public DataTable table_Select(String sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        public void table_Command(String sql)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
