using System;
using System.Data;
using System.Data.SqlClient;

namespace XUAN_HIEU_4665
{
    public class LopXLDL
    {
        public LopXLDL()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private SqlConnection ketNoi()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\C#\project\XUAN_HIEU_4665\XUAN_HIEU_4665\XuanHieuSchool.mdf;Integrated Security=True");
            try
            {
                conn.Open();
            }
            catch (SqlException)
            {
                return null;
            }
            return conn;
        }

        public int xuLyStored(string stored, string[] vals, string[] pars)
        {
            SqlConnection con = ketNoi();
            SqlCommand comm = new SqlCommand(stored, con);
            for (int i = 0; i < vals.Length; i++)
                comm.Parameters.Add(new SqlParameter(pars[i], vals[i]));
            comm.CommandType = CommandType.StoredProcedure;
            return comm.ExecuteNonQuery();

        }

        public DataSet docNhieuDLStored(string stored, string[] vals, string[] pars)
        {
            SqlConnection con = ketNoi();
            SqlCommand comm = new SqlCommand(stored, ketNoi());
            SqlDataAdapter ada = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            for (int i = 0; i < vals.Length; i++)
                comm.Parameters.Add(new SqlParameter(pars[i], vals[i]));
            comm.CommandType = CommandType.StoredProcedure;
            ada.Fill(ds);
            return ds;
        }
    }

}





    


