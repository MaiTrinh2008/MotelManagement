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
    public partial class frmCusRent : Form
    {
        public frmCusRent()
        {
            InitializeComponent();
        }
        public void ThemKhachHang()
        {

            SqlParameter[] sqlParams2 = {
                new SqlParameter("@makh",txtMaKH.Text.Trim()),
                new SqlParameter("@hotenkhachhang",txtTenKhachHang.Text.Trim()),
                new SqlParameter("@sdt",txtSDT.Text.Trim()),
                new SqlParameter("@cmnd",txtCMND.Text.Trim()),
                new SqlParameter("@maphong",Libs.PhongTro._maphong.Trim()),
                new SqlParameter ("@diachi",txtDiaChi.Text.Trim()),
                new SqlParameter("@trangthai",'1')
            };
            Libs.Database.Data.ExecuteNonQuery("LuuThongTinKhachHang", CommandType.StoredProcedure, sqlParams2);
        }
        public void LoadDSKH()
        {
            DataTable data = new DataTable();
            data = Libs.Database.Data.ExcuteToDataTable("select * from KhachHang where KhachHang.MaPhong='" + Libs.PhongTro._maphong.Trim() + "' and KhachHang.TrangThai=1");
            dtgthongtinKH.DataSource = null;
            dtgthongtinKH.DataSource = data;

        }
        public void LoadMaKhachHang()
        {
            DataTable data = new DataTable();
            data = Libs.Database.Data.ExcuteToDataTable("select top 1 KhachHang.MaKhachHang from KhachHang order by KhachHang.MaKhachHang Desc", CommandType.Text);
            string a = "";
            a = data.Rows[0]["MaKhachHang"].ToString();
            int b = int.Parse(a.Substring(2));
            txtMaKH.Text = "KH" + (b + 1).ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text == "" || txtCMND.Text == "" || txtDiaChi.Text == "" || txtMaKH.Text == "" || txtSDT.Text == "" || txtTenKhachHang.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                
                ThemKhachHang();
                LoadDSKH();
                LoadMaKhachHang();
                txtMaPhong.Text = Libs.PhongTro._maphong.Trim();
                txtCMND.Clear();
                txtDiaChi.Clear();
                txtSDT.Clear();
                txtTenKhachHang.Clear();
                MessageBox.Show("Thêm Mới Thành Công!!", "Thông Báo", MessageBoxButtons.OK);
            } }

        private void frmCusRent_Load(object sender, EventArgs e)
        {
            txtMaPhong.Text = Libs.PhongTro._maphong;
            LoadMaKhachHang();
        }
    }
}
