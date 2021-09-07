using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLoginDoAn
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Username!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                txtUsername.Focus();
            }
            else if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Password!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                txtPassword.Focus();
            }
            else if (txtUsername.Text.Trim() != "" && txtPassword.Text.Trim() != "")
            {
                kiemtradangnhap();
            }
        }
        public void kiemtradangnhap()
        {

           
            SqlParameter[] sqlParams2 = {
                new SqlParameter("@username",txtUsername.Text),
                new SqlParameter("@password", txtPassword.Text)
            };

            
            DataTable table = new DataTable();

            
           
                table = Libs.Database.Data.ExcuteToDataTable("KiemTraDangNhap", CommandType.StoredProcedure, sqlParams2);
                if (table.Rows.Count > 0)
                {
                    string permission = table.Rows[0]["Permission"].ToString();
                    //lưu vào object
                    string username = table.Rows[0]["Username"].ToString();
                    string maphong = table.Rows[0]["MaPhong"].ToString();
                    Libs.KhachTro.username = username;
                    Libs.KhachTro.maphong = maphong;
                    //string a = "0";
                    MessageBox.Show("Đăng nhập thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    frmAdmin frmAdminMain = new frmAdmin();
                    frmCustomer frmKhachTro = new frmCustomer();
                    txtUsername.Text = null;
                    txtPassword.Text = null;
                    this.Hide();
                    if (string.Compare(permission.Trim(), "0", true) == 0)
                    {
                        frmAdminMain.Show();

                    }
                    else
                    {
                        frmKhachTro.Show();

                    }

                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại! Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            
            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
