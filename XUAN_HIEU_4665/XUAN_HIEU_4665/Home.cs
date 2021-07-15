using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;

namespace XUAN_HIEU_4665
{
    public partial class Home : Form
    {
        SVbus sv = new SVbus();
        public Home()
        {
            InitializeComponent();
            string sql = "SELECT * FROM SINHVIEN";  
            sv.view(sql,dataGridView1);
        }
        
        LopXLDL xl = new LopXLDL();
        
        

        private void btnThem_Click(object sender, EventArgs e)
        {
            string[] values = new string[]{
                txtMasv.Text,
                TxtTensv.Text,
                txtGt.Text,
                txtDiachi.Text,
                txtDiemtb.Text,
               
                
            };

            string[] pars = new string[]
            {
                "@masv",
                "@tensv",
                "@gioitinh",
                "@diachi",
                "@diemtb",
               
            };
            if (xl.xuLyStored("addNewStudent", values, pars) == 1)
                lblTB.Text = "";
            else
                lblTB.Text = "";
            string sql = "SELECT * FROM SINHVIEN";
            sv.view(sql, dataGridView1);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string[] values = new string[]{
                txtMasv.Text,
                TxtTensv.Text,
                                
                txtGt.Text,
                txtDiachi.Text,
                txtDiemtb.Text,
               

            };

            string[] pars = new string[]
            {
                "@masv",
                "@tensv",
                "@gioitinh",
                "@diachi",
                "@diemtb",
            };
            if (xl.xuLyStored("UpdateStudent", values, pars) == 1)
                lblTB.Text = "Thay đổi thành công";
            else
                lblTB.Text = "Thay đổi thất bại";
            string sql = "SELECT * FROM SINHVIEN";
            sv.view(sql, dataGridView1);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM SINHVIEN WHERE masv=" + txtMasv.Text;
            sv.view(sql, dataGridView1);
            string sql2 = "SELECT * FROM SINHVIEN";
            sv.view(sql2, dataGridView1);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Hide();
            }
        }

        

        
       
    }
}
