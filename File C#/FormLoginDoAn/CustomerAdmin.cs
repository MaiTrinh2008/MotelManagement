using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FormLoginDoAn
{
    public partial class CustomerAdmin : UserControl
    {
        public CustomerAdmin()
        {
            InitializeComponent();
        }
        public void loadDSphongdathue()
        {

            DataTable data = new DataTable();
            data = Libs.Database.Data.ExcuteToDataTable("select Room.MaPhong from Room where room.TrangThai=1", CommandType.Text);
            cbMaPhong.DataSource = data;
            cbMaPhong.DisplayMember = "MaPhong";
        }
        public void ThemKhachHang()
        {

            SqlParameter[] sqlParams2 = {
                new SqlParameter("@makh",txtMaKH.Text.Trim()),
                new SqlParameter("@hotenkhachhang",txtTenKH.Text.Trim()),
                new SqlParameter("@sdt",txtPhone.Text.Trim()),
                new SqlParameter("@cmnd",txtCMND.Text.Trim()),
                new SqlParameter("@maphong",cbMaPhong.Text.Trim()),
                new SqlParameter ("@diachi",txtDiaChi.Text.Trim()),
                new SqlParameter ("@trangthai","1")

            };
            Libs.Database.Data.ExecuteNonQuery("LuuThongTinKhachHang", CommandType.StoredProcedure, sqlParams2);
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
        public void LoadDSKH()
        {
            DataTable data = new DataTable();
            data = Libs.Database.Data.ExcuteToDataTable("select * from KhachHang where KhachHang.MaPhong='"+cbMaPhong.Text.Trim()+"' and KhachHang.TrangThai='1'", CommandType.Text);
            dtgthongtinKH.DataSource = null;
            dtgthongtinKH.DataSource = data;

        }
        public void SuaTTKH()
        {
            SqlParameter[] sqlParams2 = {
                new SqlParameter("@makh",txtMaKH.Text.Trim()),
                new SqlParameter("@tenkh",txtTenKH.Text.Trim()),
                new SqlParameter("@sdt",txtPhone.Text.Trim()),
                new SqlParameter("@cmnd",txtCMND.Text.Trim()),
                //new SqlParameter("@maphong",cbMaPhong.Text.Trim()),
                new SqlParameter ("@diachi",txtDiaChi.Text.Trim()),
                new SqlParameter ("@trangthai","1")

            };
            Libs.Database.Data.ExecuteNonQuery("admin_SuaTTKH", CommandType.StoredProcedure, sqlParams2);
        }

        private void cbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDSKH();
        }

        private void CustomerAdmin_Load(object sender, EventArgs e)
        {
            loadDSphongdathue();
            LoadMaKhachHang();
            DataTable data = new DataTable();
            data = Libs.Database.Data.ExcuteToDataTable("select * from KhachHang", CommandType.Text);
            dtgthongtinKH.DataSource = null;
            dtgthongtinKH.DataSource = data;
        }
        
        private void btnADD_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "" || txtTenKH.Text == "" || txtPhone.Text == "" || txtDiaChi.Text == "" || txtCMND.Text == ""||cbMaPhong.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Thêm mới thành công!!", "Thông Báo", MessageBoxButtons.OK);

                ThemKhachHang();
                LoadDSKH();
                LoadMaKhachHang();
                cbMaPhong.Text = "";
                txtCMND.Clear();
                txtDiaChi.Clear();
                txtPhone.Clear();
                txtTenKH.Clear();
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "" || txtTenKH.Text == "" || txtPhone.Text == "" || txtDiaChi.Text == "" || txtCMND.Text == ""|| cbMaPhong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Check out thành công!!", "Thông Báo", MessageBoxButtons.OK);

                Libs.Database.Data.ExecuteNonQuery("update KhachHang set TrangThai = '0' where MaKhachHang = '" + txtMaKH.Text.Trim() + "'");
                LoadDSKH();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "" || txtTenKH.Text == "" || txtPhone.Text == "" || txtDiaChi.Text == "" || txtCMND.Text == ""|| cbMaPhong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Chỉnh sửa thành công!!", "Thông Báo", MessageBoxButtons.OK);
                SuaTTKH();
                LoadDSKH();
            }
        }

        private void dtgthongtinKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgthongtinKH.Rows.Count > 0)
            {
                int pos = dtgthongtinKH.CurrentRow.Index;
                txtMaKH.Text = dtgthongtinKH.Rows[pos].Cells[0].Value.ToString();
                txtTenKH.Text = dtgthongtinKH.Rows[pos].Cells[1].Value.ToString();
                txtPhone.Text = dtgthongtinKH.Rows[pos].Cells[2].Value.ToString();
                txtCMND.Text = dtgthongtinKH.Rows[pos].Cells[3].Value.ToString();
                cbMaPhong.Text = dtgthongtinKH.Rows[pos].Cells[4].Value.ToString();
                txtDiaChi.Text = dtgthongtinKH.Rows[pos].Cells[5].Value.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtTenKH.Text = ""; txtPhone.Text = ""; txtDiaChi.Text = ""; txtCMND.Text = ""; cbMaPhong.Text = "";
            LoadMaKhachHang();
        }
    }
}
