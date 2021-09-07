namespace FormLoginDoAn
{
    partial class Statistic
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dtgstatistic = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnThongKeTheoThang = new System.Windows.Forms.Button();
            this.btnThongKeTheoPhong = new System.Windows.Forms.Button();
            this.btnThongKeTheoKhuVuc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgstatistic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgstatistic
            // 
            this.dtgstatistic.BackgroundColor = System.Drawing.Color.White;
            this.dtgstatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgstatistic.Location = new System.Drawing.Point(101, 46);
            this.dtgstatistic.Name = "dtgstatistic";
            this.dtgstatistic.RowHeadersWidth = 51;
            this.dtgstatistic.RowTemplate.Height = 24;
            this.dtgstatistic.Size = new System.Drawing.Size(462, 119);
            this.dtgstatistic.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(21, 192);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Revenue";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(816, 332);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // btnThongKeTheoThang
            // 
            this.btnThongKeTheoThang.BackColor = System.Drawing.Color.Crimson;
            this.btnThongKeTheoThang.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeTheoThang.Location = new System.Drawing.Point(596, 46);
            this.btnThongKeTheoThang.Name = "btnThongKeTheoThang";
            this.btnThongKeTheoThang.Size = new System.Drawing.Size(189, 35);
            this.btnThongKeTheoThang.TabIndex = 3;
            this.btnThongKeTheoThang.Text = "Thống Kê Theo Tháng";
            this.btnThongKeTheoThang.UseVisualStyleBackColor = false;
            this.btnThongKeTheoThang.Click += new System.EventHandler(this.btnThongKeTheoThang_Click);
            // 
            // btnThongKeTheoPhong
            // 
            this.btnThongKeTheoPhong.BackColor = System.Drawing.Color.Crimson;
            this.btnThongKeTheoPhong.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeTheoPhong.Location = new System.Drawing.Point(596, 87);
            this.btnThongKeTheoPhong.Name = "btnThongKeTheoPhong";
            this.btnThongKeTheoPhong.Size = new System.Drawing.Size(189, 36);
            this.btnThongKeTheoPhong.TabIndex = 4;
            this.btnThongKeTheoPhong.Text = "Thống Kê Theo Phòng";
            this.btnThongKeTheoPhong.UseVisualStyleBackColor = false;
            this.btnThongKeTheoPhong.Click += new System.EventHandler(this.btnThongKeTheoPhong_Click);
            // 
            // btnThongKeTheoKhuVuc
            // 
            this.btnThongKeTheoKhuVuc.BackColor = System.Drawing.Color.Crimson;
            this.btnThongKeTheoKhuVuc.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeTheoKhuVuc.Location = new System.Drawing.Point(596, 129);
            this.btnThongKeTheoKhuVuc.Name = "btnThongKeTheoKhuVuc";
            this.btnThongKeTheoKhuVuc.Size = new System.Drawing.Size(189, 36);
            this.btnThongKeTheoKhuVuc.TabIndex = 5;
            this.btnThongKeTheoKhuVuc.Text = "Thống Kê Theo Khu Vực";
            this.btnThongKeTheoKhuVuc.UseVisualStyleBackColor = false;
            this.btnThongKeTheoKhuVuc.Click += new System.EventHandler(this.btnThongKeTheoKhuVuc_Click);
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnThongKeTheoKhuVuc);
            this.Controls.Add(this.btnThongKeTheoPhong);
            this.Controls.Add(this.btnThongKeTheoThang);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dtgstatistic);
            this.Name = "Statistic";
            this.Size = new System.Drawing.Size(866, 567);
            this.Load += new System.EventHandler(this.Statistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgstatistic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgstatistic;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnThongKeTheoThang;
        private System.Windows.Forms.Button btnThongKeTheoPhong;
        private System.Windows.Forms.Button btnThongKeTheoKhuVuc;
    }
}
