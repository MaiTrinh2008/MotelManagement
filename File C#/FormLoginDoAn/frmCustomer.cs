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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        public void LoadthongTinPhong()
        {
            SqlParameter[] sqlParams2 = {
                 new SqlParameter("@username",Libs.KhachTro.username.ToString())};
            DataTable table = new DataTable();
            table = Libs.Database.Data.ExcuteToDataTable("XemDanhSachPhong", CommandType.StoredProcedure, sqlParams2);
            dgKhachTro.DataSource = null;
            dgKhachTro.DataSource = table;
        }
        public void LoadthongTinHoaDon()
        {
            SqlParameter[] sqlParams2 = {
                 new SqlParameter("@username",Libs.KhachTro.username.ToString())};
            DataTable table = new DataTable();
            table = Libs.Database.Data.ExcuteToDataTable("XemHoaDon", CommandType.StoredProcedure, sqlParams2);
            dgInvoice.DataSource = null;
            dgInvoice.DataSource = table;
        }
        public void LoadAccount()
        {
            
            DataTable table = new DataTable();
            table = Libs.Database.Data.ExcuteToDataTable("select * from Account where Account.username = '"+Libs.KhachTro.username.ToString()+"'", CommandType.Text);
            dgAccount.DataSource = null;
            dgAccount.DataSource = table;
        }
        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnDoiMatKhau_Click(object sender, EventArgs e)
        {
            SqlParameter[] sqlParams2 = {
                 new SqlParameter("@username",Libs.KhachTro.username.ToString()),
            new SqlParameter("@password",txtDoiMatKhau.Text.ToString())};

            //DataTable table = new DataTable();
            Libs.Database.Data.ExecuteNonQuery("DoiMatKhau", CommandType.StoredProcedure, sqlParams2);
            LoadAccount();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LblMaHD_Click(object sender, EventArgs e)
        {

        }

        private void gbThongKe_Enter(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            //LoadthongTinPhong();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            LoadthongTinPhong();
            LoadthongTinHoaDon();
        }

        private void dgKhachTro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tcLOM_Click(object sender, EventArgs e)
        {
            LoadthongTinPhong();
        }

        private void tcIV_Click(object sender, EventArgs e)
        {
            LoadthongTinHoaDon();
        }

        private void tcEA_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void txtDoiMatKhau_Click(object sender, EventArgs e)
        {
            txtDoiMatKhau.Clear();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }
    }
}
