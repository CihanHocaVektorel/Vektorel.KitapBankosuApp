using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.DAL
{
    public class Helper
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);

        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(cmdtext, cn);
                if (p != null)
                {
                    cmd.Parameters.AddRange(p);
                }
                cn.Open();
                int sonuc = cmd.ExecuteNonQuery();
                return sonuc;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (cn != null && cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        public SqlDataReader ExecuteReader(string cmdtext, SqlParameter[] p = null,CommandType type=CommandType.Text)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(cmdtext, cn);
                cmd.CommandType = type;
                if (p != null)
                {
                    cmd.Parameters.AddRange(p);
                }
                cn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                //if (cn != null && cn.State != ConnectionState.Closed)
                //{
                //    cn.Close();
                //}
            }
        }


        public DataTable MyDataTable(string cmdtext, SqlParameter[] p = null,CommandType type=CommandType.Text)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmdtext, cn);
            da.SelectCommand.CommandType = type;
            if (p != null)
            {
                da.SelectCommand.Parameters.AddRange(p);
            }
            da.Fill(dt);
            return dt;
        }
    }
}
