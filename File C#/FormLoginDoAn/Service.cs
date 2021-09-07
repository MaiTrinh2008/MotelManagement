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
    public partial class Service : UserControl
    {
        public Service()
        {
            InitializeComponent();
        }
        public void LoadDSDV()
        {
            DataTable dt = new DataTable();
            dt = Libs.Database.Data.ExcuteToDataTable("select * from DichVu", CommandType.Text);
            dtgService.DataSource = null;
            dtgService.DataSource = dt;
        }
        
        public void SuaDV()
        {
            SqlParameter[] sqlParams2 = {
                new SqlParameter("@madv",txtServiceID.Text),
                new SqlParameter("@tendv", txtName.Text),
                new SqlParameter("@giadv", txtGia.Text)
            };
            DataTable dt = new DataTable();
            dt = Libs.Database.Data.ExcuteToDataTable("SuaDV", CommandType.StoredProcedure, sqlParams2);
        }
       
        private void Service_Load(object sender, EventArgs e)
        {
            
            LoadDSDV();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtGia.Text == "" || txtName.Text == "" || txtServiceID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Chỉnh sửa thành công!!", "Thông Báo", MessageBoxButtons.OK);
                SuaDV();
                LoadDSDV();
            }
        }
        private void dtgService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgService.Rows.Count > 0)
            {
                int pos = dtgService.CurrentRow.Index;
                txtServiceID.Text = dtgService.Rows[pos].Cells[0].Value.ToString();
                txtName.Text = dtgService.Rows[pos].Cells[1].Value.ToString();
                txtGia.Text = dtgService.Rows[pos].Cells[2].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtGia.Text = ""; txtName.Text = ""; txtServiceID.Text = "";
            
        }
    }
}
