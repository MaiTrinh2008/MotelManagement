using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLoginDoAn
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            invoice1.BringToFront();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            rentRoom1.BringToFront();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            room1.BringToFront();
  
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            service1.BringToFront();

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            customerAdmin1.BringToFront();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            checkOut1.BringToFront();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            statistic1.BringToFront();
                }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            background1.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Close();
            frmLogin.Show();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            dtgAdmin.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtgAdmin.Show();
            DataTable data = new DataTable();
            data = Libs.Database.Data.ExcuteToDataTable("select * from HoaDon where HoaDon.MaHD='"+txtSearch.Text.Trim()+"'", CommandType.Text);
            if(data.Rows.Count<1)
            {
                MessageBox.Show("Không tìm thấy kết quả tương ứng", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                dtgAdmin.DataSource = null;
                dtgAdmin.DataSource = data;
            }    
        }
    }
}
