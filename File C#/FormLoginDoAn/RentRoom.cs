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
    public partial class RentRoom : UserControl
    {
        public RentRoom()
        {
            InitializeComponent();
        }
        public void loadDSPhongChuaThue()
        {
            DataTable data = new DataTable();
            data = Libs.Database.Data.ExcuteToDataTable("select Room.MaPhong from Room where room.TrangThai=0", CommandType.Text);
            cbMaPhong.DataSource = data;
            cbMaPhong.DisplayMember = "MaPhong";
        }
        public void XemDSThuePhong()
        {
            DataTable data = new DataTable();
            data = Libs.Database.Data.ExcuteToDataTable("select * from ThuePhong", CommandType.Text);
            dgthuephong.DataSource = null;
            dgthuephong.DataSource = data;
        }

        public void LoadMaThuePhong()
        {
            DataTable data = new DataTable();
            data = Libs.Database.Data.ExcuteToDataTable("select top 1 ThuePhong.MaThuePhong from ThuePhong order by ThuePhong.MaThuePhong Desc", CommandType.Text);
            string a = "";
            a = data.Rows[0]["MaThuePhong"].ToString();
            int b = int.Parse(a.Substring(2));
            txtMaThuePhong.Text = "TP" + (b + 1).ToString();
        }
        public void ThuePhong()
        {

            SqlParameter[] sqlParams2 = {
                new SqlParameter("@mathuephong",txtMaThuePhong.Text.Trim()),
                new SqlParameter("@maphong",cbMaPhong.Text.Trim()),
                new SqlParameter("@hotenchuphong",txtTenKH.Text.Trim()),
                new SqlParameter("@tiencoc",txtTienCoc.Text.Trim()),
                new SqlParameter("@ngaybatdauthue",DateTime.Parse(txtNgayBatDau.Text).ToShortDateString().Trim()),
                //new SqlParameter("@ngaytaphong",DateTime.Parse(txtTenKH.Text).ToShortDateString().Trim())
            };
            Libs.Database.Data.ExecuteNonQuery("admin_ThuePhong", CommandType.StoredProcedure, sqlParams2);
            Libs.PhongTro._maphong = cbMaPhong.Text.Trim();
            //cbMaPhong.Text = Libs.PhongTro._maphong.Trim();
        }
        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RentRoom_Load(object sender, EventArgs e)
        {
            loadDSPhongChuaThue();
            XemDSThuePhong();
            LoadMaThuePhong();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaThuePhong.Text == "" || txtTenKH.Text == "" || txtNgayBatDau.Text == "" || txtTienCoc.Text == ""||cbMaPhong.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                ThuePhong();
                loadDSPhongChuaThue();
                XemDSThuePhong();
                
                MessageBox.Show("Vui lòng nhập thông tin khách hàng.", "Thông báo", MessageBoxButtons.OK);
                frmCusRent nhapthongtinkhachhang = new frmCusRent();
                nhapthongtinkhachhang.Show();
                //ThuePhong();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaThuePhong.Text = ""; txtTenKH.Text = ""; txtNgayBatDau.Text = ""; txtTienCoc.Text = ""; cbMaPhong.Text = "";
            
        }
    }
}
