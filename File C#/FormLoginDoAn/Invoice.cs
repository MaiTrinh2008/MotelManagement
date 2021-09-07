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
    public partial class Invoice : UserControl
    {
        public Invoice()
        {
            InitializeComponent();
        }
        public void LoadTienPhong()
        {
            
            DataTable data = new DataTable();
            data = Libs.Database.Data.ExcuteToDataTable("Select Room.Gia from room where Room.MaPhong='"+cbMaPhong.Text.Trim()+"'", CommandType.Text);
            txtTienPhong.Text = data.Rows[0]["Gia"].ToString();
        }
        public void LoadGiaDV()
        {
            DataTable data = Libs.Database.Data.ExcuteToDataTable("select DichVu.GiaDV from DichVu ", CommandType.Text);
            txtDGDIen.Text = data.Rows[0]["GiaDV"].ToString();
            txtDGNuoc.Text = data.Rows[1]["GiaDV"].ToString();

            txtRac.Text = data.Rows[3]["GiaDV"].ToString();
            if (chkWifi.Checked == false)
            {
                txtWifi.Text = 0 + "";
            }
            else
            {
                txtWifi.Text = data.Rows[2]["GiaDV"].ToString();
            }
        }
        public void loadDSPhongDaThue()
        {
            DataTable data = new DataTable();
            data = Libs.Database.Data.ExcuteToDataTable("select Room.MaPhong from Room where room.TrangThai=1", CommandType.Text);
            cbMaPhong.DataSource = data;
            cbMaPhong.DisplayMember = "MaPhong";
        }
        public void loadMaHD()
        {
            DataTable data = new DataTable();
            data = Libs.Database.Data.ExcuteToDataTable("select top 1 HoaDon.MaHD from HoaDon order by MaHD desc", CommandType.Text);
            string a = "";
            a = data.Rows[0]["MaHD"].ToString();
            int b = int.Parse(a.Substring(2));
            txtMaHD.Text = "HD" + (b + 1).ToString();
        }
        public void LoadMaThuePhong()
        {
            DataTable data = new DataTable();
            data = Libs.Database.Data.ExcuteToDataTable("select ThuePhong.MaThuePhong from ThuePhong where ThuePhong.MaPhong='"+cbMaPhong.Text.Trim()+"' and ThuePhong.NgayTraPhong is null", CommandType.Text);
            txtMaThuePhong.Text = data.Rows[0]["MaThuePhong"].ToString();
        }
        public void TinhTien()
        {
            int k = int.Parse(txtDGDIen.Text);
            int l = int.Parse(txtkgDien.Text);
            int m = int.Parse(txtkgNuoc.Text);
            int n = int.Parse(txtDGNuoc.Text);
            int a = k * l;
            txtTienDien.Text = a + "";
            int b = m * n;
            txtNuoc.Text = b + "";
            int c = int.Parse(txtRac.Text);
            int d = int.Parse(txtWifi.Text);
            int f = a + b + c + d;
            txtTienDichVu.Text = f.ToString();
            int g = int.Parse(txtTienPhong.Text);
            //int h = int.Parse(txtTienDichVu.Text);
            int i = int.Parse(txtGiamGia.Text);
            int j = g + f - i;
            txtTongTien.Text = j.ToString();
        }
        public void updatehoadon()
        {
            SqlParameter[] sqlParams2 = {
                new SqlParameter("@mahd",txtMaHD.Text.Trim()),
                new SqlParameter("@mathuephong",txtMaThuePhong.Text.Trim()),
                new SqlParameter("@tienphong",txtTienPhong.Text.Trim()),
                new SqlParameter("@tiendichvu",txtTienPhong.Text.Trim()),
                new SqlParameter("@tongtien",txtTongTien.Text.Trim()),
                new SqlParameter("@giamgia",txtGiamGia.Text.Trim()),
                new SqlParameter("@ngaythanhtoan",null),
            };
            Libs.Database.Data.ExecuteNonQuery("Admin_HoaDonChuaTT", CommandType.StoredProcedure, sqlParams2);
        }
        public void LoadDSHDchuaTT()
        {
            DataTable data = Libs.Database.Data.ExcuteToDataTable("select HoaDon.MaHD,HoaDon.MaThuePhong,ThuePhong.MaPhong,HoaDon.TienPhong,HoaDon.TienDichVu,HoaDon.TongTien,HoaDon.NgayThanhToan from HoaDon inner join ThuePhong on HoaDon.MaThuePhong=ThuePhong.MaThuePhong where HoaDon.NgayThanhToan is null", CommandType.Text);
            dtgHoaDon.DataSource = null;
            dtgHoaDon.DataSource = data;
        }
        public void UpdateThueDV()
        {
            SqlParameter[] sqlParams2 =
            {
                new SqlParameter("@mahd",txtMaHD.Text.Trim()),
                new SqlParameter("@maDV","DV01"),
                new SqlParameter("@giaDV",txtTienDien.Text.Trim()),
                new SqlParameter("@solan",txtkgDien.Text.Trim()),
            };
            Libs.Database.Data.ExecuteNonQuery("Admin_UpdateThueDV", CommandType.StoredProcedure, sqlParams2);
            SqlParameter[] sqlParams3 =
            {
                new SqlParameter("@mahd",txtMaHD.Text.Trim()),
                new SqlParameter("@maDV","DV02"),
                new SqlParameter("@giaDV",txtNuoc.Text.Trim()),
                new SqlParameter("@solan",txtkgNuoc.Text.Trim())
            };
            Libs.Database.Data.ExecuteNonQuery("Admin_UpdateThueDV", CommandType.StoredProcedure, sqlParams3);
            SqlParameter[] sqlParams4 =
            {
                new SqlParameter("@mahd",txtMaHD.Text.Trim()),
                new SqlParameter("@maDV","DV04"),
                new SqlParameter("@giaDV",txtRac.Text.Trim()),
                new SqlParameter("@solan","1")
            };
            Libs.Database.Data.ExecuteNonQuery("Admin_UpdateThueDV", CommandType.StoredProcedure, sqlParams4);
            if (chkWifi.Checked == true)
            {
                SqlParameter[] sqlParams5 =
                {
                new SqlParameter("@mahd",txtMaHD.Text.Trim()),
                new SqlParameter("@maDV","DV03"),
                new SqlParameter("@giaDV",txtWifi.Text.Trim()),
                new SqlParameter("@solan","1")
            };
                Libs.Database.Data.ExecuteNonQuery("Admin_UpdateThueDV", CommandType.StoredProcedure, sqlParams5);
            }
        }
        public void updatethanhtoan()
        {
            SqlParameter[] sqlParams2 =
            {
                new SqlParameter("@mahd",txtMaHD.Text.Trim()),
                new SqlParameter("@ngaythanhtoan",DateTime.Parse(txtNgayThanhToan.Text).ToShortDateString().Trim())
            };
            Libs.Database.Data.ExecuteNonQuery("Admin_UpdateThanhToan", CommandType.StoredProcedure, sqlParams2);
        }


        private void Invoice_Load(object sender, EventArgs e)
        {
            loadDSPhongDaThue();
            loadMaHD();
            cbMaPhong.Text = null;
            LoadDSHDchuaTT();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            LoadMaThuePhong();
            LoadTienPhong();
            LoadGiaDV();
            TinhTien();
        }

        private void dtgHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgHoaDon.Rows.Count > 0)
            {
                int pos = dtgHoaDon.CurrentRow.Index;
                txtMaHD.Text = dtgHoaDon.Rows[pos].Cells[0].Value.ToString();
                txtMaThuePhong.Text = dtgHoaDon.Rows[pos].Cells[1].Value.ToString();
                cbMaPhong.Text = dtgHoaDon.Rows[pos].Cells[2].Value.ToString();
                txtTienPhong.Text = dtgHoaDon.Rows[pos].Cells[3].Value.ToString();
                txtTienDichVu.Text = dtgHoaDon.Rows[pos].Cells[4].Value.ToString();
                txtTongTien.Text = dtgHoaDon.Rows[pos].Cells[5].Value.ToString();
                //LoadGiaDV();
                DataTable dt = Libs.Database.Data.ExcuteToDataTable("select ThueDV.SoLan from ThueDV where MaHD='" + txtMaHD.Text.Trim() + "'", CommandType.Text);
                txtkgDien.Text = dt.Rows[0]["SoLan"].ToString();
                txtkgNuoc.Text = dt.Rows[1]["SoLan"].ToString();
                if (dt.Rows.Count > 3)
                {
                    chkWifi.Checked = true;
                    //LoadGiaDV();
                }
                else if (dt.Rows.Count <= 3)
                {
                    chkWifi.Checked = false;
                    //LoadGiaDV();
                }
                LoadGiaDV();
                TinhTien();
            }
        }

        private void chkWifi_CheckedChanged(object sender, EventArgs e)
        {
            if (txtTongTien.Text != "")
            {
                LoadGiaDV();
                TinhTien();
            }
            else
            {
                LoadGiaDV();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "" ||
                txtDGDIen.Text == ""||
                txtDGNuoc.Text == "" ||
                txtGiamGia.Text == "" ||
                txtkgDien.Text == ""||
            txtkgNuoc.Text == ""||
            txtMaHD.Text == ""||
            txtMaThuePhong.Text == ""||
            txtNuoc.Text == ""||
            txtRac.Text == ""||
            txtTienDichVu.Text == ""||
            txtTienDien.Text == ""||
            txtTienPhong.Text == ""||
            txtTongTien.Text == ""||
            txtWifi.Text == ""
                )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Thêm Mới Thành Công!!", "Thông Báo", MessageBoxButtons.OK);
                updatehoadon();
                UpdateThueDV();
                txtDGDIen.Text = "";
                txtDGNuoc.Text = "";
                //txtGiamGia.Text = "";
                txtkgDien.Text = "";
                txtkgNuoc.Text = "";
                txtMaHD.Text = "";
                txtMaThuePhong.Text = "";
                txtNuoc.Text = "";
                txtRac.Text = "";
                txtTienDichVu.Text = "";
                txtTienDien.Text = "";
                txtTienPhong.Text = "";
                txtTongTien.Text = "";
                txtWifi.Text = "";
                loadMaHD();
                LoadDSHDchuaTT();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtNgayThanhToan.Text=="")
            {
                MessageBox.Show("Vui lòng nhập ngày thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }    
            else
            {
                MessageBox.Show("Thanh toán thành công!!", "Thông Báo", MessageBoxButtons.OK);
                updatethanhtoan();
                LoadDSHDchuaTT();
            }    
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDGDIen.Text = "";
            txtDGNuoc.Text = "";
            //txtGiamGia.Text = "";
            txtkgDien.Text = "";
            txtkgNuoc.Text = "";
            txtMaHD.Text = "";
            txtMaThuePhong.Text = "";
            txtNuoc.Text = "";
            txtRac.Text = "";
            txtTienDichVu.Text = "";
            txtTienDien.Text = "";
            txtTienPhong.Text = "";
            txtTongTien.Text = "";
            txtWifi.Text = "";
            loadMaHD();
        }
    }
}
