namespace FormLoginDoAn
{
    partial class frmCustomer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tcLOM = new System.Windows.Forms.TabControl();
            this.lblMaKhachHang = new System.Windows.Forms.TabPage();
            this.dgKhachTro = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgInvoice = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgAccount = new System.Windows.Forms.DataGridView();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.txtDoiMatKhau = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tcLOM.SuspendLayout();
            this.lblMaKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKhachTro)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoice)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // tcLOM
            // 
            this.tcLOM.Controls.Add(this.lblMaKhachHang);
            this.tcLOM.Controls.Add(this.tabPage2);
            this.tcLOM.Controls.Add(this.tabPage3);
            this.tcLOM.Location = new System.Drawing.Point(2, 0);
            this.tcLOM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcLOM.Name = "tcLOM";
            this.tcLOM.SelectedIndex = 0;
            this.tcLOM.Size = new System.Drawing.Size(587, 475);
            this.tcLOM.TabIndex = 1;
            this.tcLOM.Click += new System.EventHandler(this.tcEA_Click);
            // 
            // lblMaKhachHang
            // 
            this.lblMaKhachHang.BackColor = System.Drawing.Color.White;
            this.lblMaKhachHang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lblMaKhachHang.BackgroundImage")));
            this.lblMaKhachHang.Controls.Add(this.btnLogout);
            this.lblMaKhachHang.Controls.Add(this.dgKhachTro);
            this.lblMaKhachHang.Location = new System.Drawing.Point(4, 25);
            this.lblMaKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblMaKhachHang.Name = "lblMaKhachHang";
            this.lblMaKhachHang.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblMaKhachHang.Size = new System.Drawing.Size(579, 446);
            this.lblMaKhachHang.TabIndex = 0;
            this.lblMaKhachHang.Text = "List of member";
            // 
            // dgKhachTro
            // 
            this.dgKhachTro.BackgroundColor = System.Drawing.Color.White;
            this.dgKhachTro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKhachTro.Location = new System.Drawing.Point(36, 37);
            this.dgKhachTro.Name = "dgKhachTro";
            this.dgKhachTro.RowHeadersWidth = 51;
            this.dgKhachTro.RowTemplate.Height = 24;
            this.dgKhachTro.Size = new System.Drawing.Size(501, 368);
            this.dgKhachTro.TabIndex = 2;
            this.dgKhachTro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKhachTro_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.dgInvoice);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(579, 446);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Invoice";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgInvoice
            // 
            this.dgInvoice.BackgroundColor = System.Drawing.Color.White;
            this.dgInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInvoice.Location = new System.Drawing.Point(39, 36);
            this.dgInvoice.Name = "dgInvoice";
            this.dgInvoice.RowHeadersWidth = 51;
            this.dgInvoice.RowTemplate.Height = 24;
            this.dgInvoice.Size = new System.Drawing.Size(493, 372);
            this.dgInvoice.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.Controls.Add(this.dgAccount);
            this.tabPage3.Controls.Add(this.btnDoiMatKhau);
            this.tabPage3.Controls.Add(this.txtDoiMatKhau);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(579, 446);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Edit Account";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgAccount
            // 
            this.dgAccount.BackgroundColor = System.Drawing.Color.White;
            this.dgAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccount.Location = new System.Drawing.Point(41, 37);
            this.dgAccount.Name = "dgAccount";
            this.dgAccount.RowHeadersWidth = 51;
            this.dgAccount.RowTemplate.Height = 24;
            this.dgAccount.Size = new System.Drawing.Size(493, 275);
            this.dgAccount.TabIndex = 4;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.Chocolate;
            this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(407, 360);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(98, 33);
            this.btnDoiMatKhau.TabIndex = 3;
            this.btnDoiMatKhau.Text = "Save";
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.BtnDoiMatKhau_Click);
            // 
            // txtDoiMatKhau
            // 
            this.txtDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoiMatKhau.ForeColor = System.Drawing.Color.Gray;
            this.txtDoiMatKhau.Location = new System.Drawing.Point(41, 363);
            this.txtDoiMatKhau.Name = "txtDoiMatKhau";
            this.txtDoiMatKhau.Size = new System.Drawing.Size(335, 26);
            this.txtDoiMatKhau.TabIndex = 2;
            this.txtDoiMatKhau.Text = "Please texting your new password!!";
            this.txtDoiMatKhau.Click += new System.EventHandler(this.txtDoiMatKhau_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkRed;
            this.btnLogout.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(411, 411);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(126, 31);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 472);
            this.Controls.Add(this.tcLOM);
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.tcLOM.ResumeLayout(false);
            this.lblMaKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgKhachTro)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoice)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tcLOM;
        private System.Windows.Forms.TabPage lblMaKhachHang;
        private System.Windows.Forms.DataGridView dgKhachTro;
        private System.Windows.Forms.DataGridView dgInvoice;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.TextBox txtDoiMatKhau;
        private System.Windows.Forms.DataGridView dgAccount;
        private System.Windows.Forms.Button btnLogout;
    }
}