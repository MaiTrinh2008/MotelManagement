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
    public partial class CheckOut : UserControl
    {
        public CheckOut()
        {
            InitializeComponent();
        }
        public void loadDSPhongDaThue()
        {
            DataTable data = new DataTable();
            data = Libs.Database.Data.ExcuteToDataTable("select Room.MaPhong from Room where room.TrangThai=1", CommandType.Text);
            cbMaPhong.DataSource = data;
            cbMaPhong.DisplayMember = "MaPhong";
        }
        public void loadMaThuePhong()
        {
            
            DataTable data = new DataTable();
            //data = Libs.Database.Data.ExcuteToDataTable("Admin_Loadmathuephong", CommandType.StoredProcedure, sqlParams2);
            data = Libs.Database.Data.ExcuteToDataTable("select ThuePhong.MaThuePhong from ThuePhong where ThuePhong.MaPhong='" + cbMaPhong.Text.Trim() + "'and ThuePhong.NgayTraPhong is null");
            txtMaThuePhong.Text = data.Rows[0]["MaThuePhong"].ToString();
        }
        public void Traphong()
        {
            SqlParameter[] sqlParams2 = {
                new SqlParameter("@mathuephong",txtMaThuePhong.Text.Trim()),
                new SqlParameter("@ngaytraphong",DateTime.Parse(txtNgayTraPhong.Text).ToShortDateString().Trim()),
                new SqlParameter("@maphong",cbMaPhong.Text.Trim())
            };
            Libs.Database.Data.ExecuteNonQuery("Admin_Traphong", CommandType.StoredProcedure, sqlParams2);
        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (txtMaThuePhong.Text == "" || txtNgayTraPhong.Text == ""||cbMaPhong.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Trả phòng  thành công!!", "Thông Báo", MessageBoxButtons.OK);
                Traphong();
                loadDSPhongDaThue();
            }
        }

        private void cbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //loadMaThuePhong();
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            loadDSPhongDaThue();
            cbMaPhong.Text = "";
        }

        private void btnLoadMTP_Click(object sender, EventArgs e)
        {
            loadMaThuePhong();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaThuePhong.Text = ""; txtNgayTraPhong.Text = ""; cbMaPhong.Text = "";
            
        }
    }
}
