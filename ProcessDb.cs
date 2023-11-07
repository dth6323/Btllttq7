using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btllttq7
{
    internal class ProcessDb
    {
        SqlConnection conn;
        public void KetNoi()
        {
            conn = new SqlConnection("Data Source=THAIHA\\TESTDB;Initial Catalog=lttq;User ID=sa;Password=123456");

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();

            }
        }
        public void DongKet()
        {
            conn = new SqlConnection("Data Source=THAIHA\\TESTDB;Initial Catalog=lttq;User ID=sa;Password=123456");

            if (conn.State != ConnectionState.Closed)
                conn.Close();
            conn.Dispose();
        }
        public DataTable DocBangsql(string sql)
        {
            KetNoi();
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(tb);
            DongKet();
            return tb;

        }
        public void CapNhat(String sql)
        {
            SqlCommand cmd = new SqlCommand();
            KetNoi();
            cmd.CommandText = sql;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            DongKet();
            cmd.Dispose();
        }
    }
}
