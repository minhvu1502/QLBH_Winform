using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.Repository
{
    public class ConnectAndQuery
    {
        public string con = @"Data Source=MINH_VU_PC\SQLEXPRESS;Initial Catalog=QLNhaHang;Integrated Security=True";
        SqlConnection sqlConection = null;

        public SqlConnection SqlConection { get => sqlConection; set => sqlConection = value; }

        public ConnectAndQuery()
        {
        }

        public void ketnoiSQL()
        {
            SqlConection = new SqlConnection(con);
            if (SqlConection.State != ConnectionState.Open)
            {
                SqlConection.Open();
            }
        }

        public void DongketnoiSQL()
        {
            if (SqlConection.State != ConnectionState.Closed)
            {
                SqlConection.Close();
            }
            SqlConection.Dispose();
        }

        public DataTable DocBang(String sql)
        {
            DataTable dtBang = new DataTable();
            ketnoiSQL();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, con);
            sqlDataAdapter.Fill(dtBang);
            DongketnoiSQL();
            return dtBang;
        }

        public DbDataReader Reader(string sql)
        {
            ketnoiSQL();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SqlConection;
            sqlCommand.CommandText = sql;
            return sqlCommand.ExecuteReader();
        }
        public void CapNhatDuLieu(String sql)
        {
            ketnoiSQL();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SqlConection;
            sqlCommand.CommandText = sql;
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            DongketnoiSQL();
        }
    }


}
