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
    public partial class Room : UserControl
    {
        public Room()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        public void XemDSPhong()
        {
            DataTable data = new DataTable();
            data = Libs.Database.Data.ExcuteToDataTable("select Room.MaPhong,Room.TrangThai,KhuVuc.khuvuc,Room.Gia from Room inner join KhuVuc on Room.idkhuvuc=KhuVuc.idkhuvuc", CommandType.Text);
            dtgDSPhong.DataSource = null;
            dtgDSPhong.DataSource = data;
        }
        public void LoadDSKV()
        {
            DataTable data = new DataTable();
            data = Libs.Database.Data.ExcuteToDataTable("select KhuVuc.KhuVuc from KhuVuc", CommandType.Text);
            cbKhuVuc.DataSource = data;
            cbKhuVuc.DisplayMember = "KhuVuc";
        }
        public void LoadTrangThai()
        {
            DataTable data = new DataTable();
            data.Columns.Add(new DataColumn("TrangThai", typeof(string)));
            data.Rows.Add("Chưa Thuê");
            data.Rows.Add("Đã Thuê");
            //data = Libs.Database.Data.ExcuteToDataTable("select Room.TrangThai from room", CommandType.Text);
            cbTrangThai.DataSource = data;
            cbTrangThai.DisplayMember = "TrangThai";
        }
        public void Sua()
        {
            int trangthai;
            if (cbTrangThai.Text.Trim() == "Chưa Thuê")
            {
                trangthai = 0;
            }
            else trangthai = 1;
            SqlParameter[] sqlParams2 = {
                new SqlParameter("@maphong",txtMaPhong.Text),
                new SqlParameter("@trangthai",trangthai),
                new SqlParameter("@khuvuc",cbKhuVuc.Text.Trim()),
                new SqlParameter("@gia",txtGia.Text.Trim())
            };
            Libs.Database.Data.ExecuteNonQuery("ChinhSuaPhong", CommandType.StoredProcedure, sqlParams2);


        }
        public void XoaPhong()
        {
            SqlParameter[] sqlParams2 = {
                new SqlParameter("@username",txtUserName.Text.Trim()),
                new SqlParameter("@maphong",txtMaPhong.Text.Trim())
            };
            Libs.Database.Data.ExecuteNonQuery("XoaPhong", CommandType.StoredProcedure, sqlParams2);
        }
        public void Loadmaphong()
        {
            DataTable data = new DataTable();
            data = Libs.Database.Data.ExcuteToDataTable("select top 1 Room.MaPhong from Room order by MaPhong desc", CommandType.Text);
            string a = "";
            a = data.Rows[0]["MaPhong"].ToString();
            int b = int.Parse(a.Substring(1));
            txtMaPhong.Text = "P" + (b + 1).ToString();
        }
        public void themaccount()
        {
            SqlParameter[] sqlParams2 = {
                new SqlParameter("@maphong",txtMaPhong.Text.Trim()),
                new SqlParameter("@username",txtUserName.Text.Trim())

            };
            Libs.Database.Data.ExecuteNonQuery("Admin_AddAcount", CommandType.StoredProcedure, sqlParams2);
        }
        public void ThemPhong()
        {
            int trangthai;
            if (cbTrangThai.Text.Trim() == "Chưa Thuê")
            {
                trangthai = 0;
            }
            else trangthai = 1;
            SqlParameter[] sqlParams2 = {
                new SqlParameter("@maphong",txtMaPhong.Text.Trim()),
                new SqlParameter("@trangthai",trangthai),
                new SqlParameter("@khuvuc",cbKhuVuc.Text.Trim()),
                new SqlParameter("@gia",txtGia.Text.Trim())
            };
            Libs.Database.Data.ExecuteNonQuery("ThemPhong", CommandType.StoredProcedure, sqlParams2);
            XemDSPhong();
        }
        private void Room_Load(object sender, EventArgs e)
        {
            XemDSPhong();
            LoadDSKV();
            LoadTrangThai();
            Loadmaphong();
        }

        private void btnThem_Click(object sender ,EventArgs e)
        {
            if (txtMaPhong.Text == "" || cbKhuVuc.Text == "" || cbTrangThai.Text == "" || txtGia.Text == ""||txtGia.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Thêm Mới Thành Công!!", "Thông Báo", MessageBoxButtons.OK);
                Loadmaphong();
                ThemPhong();
                themaccount();
                XemDSPhong();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text == "" || cbKhuVuc.Text == "" || cbTrangThai.Text == "" || txtGia.Text == "" || txtGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Chỉnh sửa thành công!!", "Thông báo", MessageBoxButtons.OK);
                Sua();
                XemDSPhong();
            }
        }

        private void dtgDSPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgDSPhong.Rows.Count > 0)
            {
                int pos = dtgDSPhong.CurrentRow.Index;
                txtMaPhong.Text = dtgDSPhong.Rows[pos].Cells[0].Value.ToString();
                //MessageBox.Show(dtgDSPhong.Rows[pos].Cells[1].Value.ToString().Trim());
                string trangthai = "";
                if (dtgDSPhong.Rows[pos].Cells[1].Value.ToString().Trim() == "False")
                {
                    trangthai = "Chưa Thuê";
                }
                else if (dtgDSPhong.Rows[pos].Cells[1].Value.ToString().Trim() == "True")
                {
                    trangthai = "Đã Thuê";
                }
                cbTrangThai.Text = trangthai;
                cbKhuVuc.Text = dtgDSPhong.Rows[pos].Cells[2].Value.ToString();
                txtGia.Text = dtgDSPhong.Rows[pos].Cells[3].Value.ToString();
            }
        }

        private void txtMaPhong_TextChanged(object sender, EventArgs e)
        {
            string a = "";
            a = txtMaPhong.Text;
            a = a.Substring(1);
            txtUserName.Text = "phong" + a + "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa ?", "Xóa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (cbTrangThai.Text == "Đã Thuê")
                    {
                        MessageBox.Show("Phòng có người ở, không thể xóa", "Warning", MessageBoxButtons.OK);
                    }
                    else
                    {
                        XoaPhong();
                        XemDSPhong();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }

            }
        }

        private void dtgDSPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cbKhuVuc.Text = ""; cbTrangThai.Text = ""; txtGia.Text = ""; txtGia.Text = "";
            Loadmaphong();
            LoadTrangThai();
        }
    }
}
