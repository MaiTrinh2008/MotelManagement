using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FormLoginDoAn
{
    public partial class Statistic : UserControl
    {
        public Statistic()
        {
            InitializeComponent();
        }
        public void LoadThongKeTheoThang()
        {
            DataTable dt = new DataTable();
            dt = Libs.Database.Data.ExcuteToDataTable("admin_ThongKeDoanhThuTheoThang", CommandType.StoredProcedure);
            dtgstatistic.DataSource = null;
            dtgstatistic.DataSource = dt;
            chart1.Series["Revenue"].XValueMember = "Thang";
            chart1.Series["Revenue"].YValueMembers = "DoanhThu";
            chart1.DataSource = dt;
            chart1.DataBind();
        }

        public void LoadThongKeTheoPhong()
        {
            DataTable dt = new DataTable();
            dt = Libs.Database.Data.ExcuteToDataTable("admin_ThongKeDoanhThuTheoPhong", CommandType.StoredProcedure);
            dtgstatistic.DataSource = null;
            dtgstatistic.DataSource = dt;
            chart1.Series["Revenue"].XValueMember = "MaPhong";
            chart1.Series["Revenue"].YValueMembers = "DoanhThu";
            chart1.DataSource = dt;
            chart1.DataBind();
        }
        public void LoadThongKeTheoKhuVuc()
        {
            DataTable dt = new DataTable();
            dt = Libs.Database.Data.ExcuteToDataTable("Admin_ThongKeDoanhThuTheoKhuVuc", CommandType.StoredProcedure);
            dtgstatistic.DataSource = null;
            dtgstatistic.DataSource = dt;
            chart1.Series["Revenue"].XValueMember = "KhuVuc";
            chart1.Series["Revenue"].YValueMembers = "DoanhThu";
            chart1.DataSource = dt;
            chart1.DataBind();
        }
        private void Statistic_Load(object sender, EventArgs e)
        {
            //LoadThongKeTheoThang();
            
        }

        private void btnThongKeTheoThang_Click(object sender, EventArgs e)
        {
            dtgstatistic.Refresh();
            LoadThongKeTheoThang();
        }

        private void btnThongKeTheoPhong_Click(object sender, EventArgs e)
        {
            dtgstatistic.Refresh();
            LoadThongKeTheoPhong();
        }

        private void btnThongKeTheoKhuVuc_Click(object sender, EventArgs e)
        {
            dtgstatistic.Refresh();
            LoadThongKeTheoKhuVuc();
        }
    }
}
