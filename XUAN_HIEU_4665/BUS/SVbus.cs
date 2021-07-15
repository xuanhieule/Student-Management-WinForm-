using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace BUS
{
    public class SVbus
    {
        public static SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\C#\project\XUAN_HIEU_4665\XUAN_HIEU_4665\XuanHieuSchool.mdf;Integrated Security=True");
        public void view(string sql, DataGridView data)
        {
            try
            {
                connect.Open();
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                connect.Close();
                data.DataSource = dt;
            }
            catch (Exception) { MessageBox.Show("Error!!!"); }
        }
    }
}
