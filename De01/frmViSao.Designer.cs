namespace De01
{
    partial class frmViSao
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
            this.dgvViSao = new System.Windows.Forms.DataGridView();
            this.MaVS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenViSao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaVS = new System.Windows.Forms.TextBox();
            this.txtTenVS = new System.Windows.Forms.TextBox();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cboHe = new System.Windows.Forms.ComboBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btNhapMoi = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViSao)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViSao
            // 
            this.dgvViSao.AllowUserToResizeRows = false;
            this.dgvViSao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViSao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViSao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaVS,
            this.TenViSao,
            this.NgayNhap,
            this.MaHe});
            this.dgvViSao.Location = new System.Drawing.Point(42, 87);
            this.dgvViSao.Name = "dgvViSao";
            this.dgvViSao.Size = new System.Drawing.Size(482, 253);
            this.dgvViSao.TabIndex = 0;
            this.dgvViSao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellDataGridViewClick);
            this.dgvViSao.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvViSao_RowHeaderMouseClick);
            // 
            // MaVS
            // 
            this.MaVS.DataPropertyName = "MaViSao";
            this.MaVS.HeaderText = "Mã Vì Sao";
            this.MaVS.Name = "MaVS";
            this.MaVS.ReadOnly = true;
            // 
            // TenViSao
            // 
            this.TenViSao.DataPropertyName = "TenViSao";
            this.TenViSao.HeaderText = "Tên Vì Sao";
            this.TenViSao.Name = "TenViSao";
            this.TenViSao.ReadOnly = true;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "Ngaynhap";
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            // 
            // MaHe
            // 
            this.MaHe.DataPropertyName = "MaHe";
            this.MaHe.HeaderText = "Mã Hệ";
            this.MaHe.Name = "MaHe";
            this.MaHe.ReadOnly = true;
            // 
            // txtMaVS
            // 
            this.txtMaVS.Location = new System.Drawing.Point(634, 87);
            this.txtMaVS.Name = "txtMaVS";
            this.txtMaVS.Size = new System.Drawing.Size(121, 20);
            this.txtMaVS.TabIndex = 1;
            this.txtMaVS.TextChanged += new System.EventHandler(this.txtMaVS_TextChanged);
            // 
            // txtTenVS
            // 
            this.txtTenVS.Location = new System.Drawing.Point(634, 132);
            this.txtTenVS.Name = "txtTenVS";
            this.txtTenVS.Size = new System.Drawing.Size(121, 20);
            this.txtTenVS.TabIndex = 2;
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayNhap.Location = new System.Drawing.Point(634, 174);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(121, 20);
            this.dtNgayNhap.TabIndex = 3;
            // 
            // cboHe
            // 
            this.cboHe.FormattingEnabled = true;
            this.cboHe.Location = new System.Drawing.Point(634, 216);
            this.cboHe.Name = "cboHe";
            this.cboHe.Size = new System.Drawing.Size(121, 21);
            this.cboHe.TabIndex = 4;
            this.cboHe.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(104, 380);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 5;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(240, 380);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 6;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.button2_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(378, 380);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 7;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btNhapMoi
            // 
            this.btNhapMoi.Location = new System.Drawing.Point(511, 380);
            this.btNhapMoi.Name = "btNhapMoi";
            this.btNhapMoi.Size = new System.Drawing.Size(75, 23);
            this.btNhapMoi.TabIndex = 8;
            this.btNhapMoi.Text = "Nhập mới";
            this.btNhapMoi.UseVisualStyleBackColor = true;
            this.btNhapMoi.Click += new System.EventHandler(this.btNhapMoi_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(634, 380);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 9;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(563, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã Vì Sao";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hệ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(312, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Danh Mục Vì Sao";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tên Vì Sao";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(563, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ngày nhập";
            // 
            // btReport
            // 
            this.btReport.Location = new System.Drawing.Point(566, 260);
            this.btReport.Name = "btReport";
            this.btReport.Size = new System.Drawing.Size(75, 23);
            this.btReport.TabIndex = 15;
            this.btReport.Text = "Tạo report";
            this.btReport.UseVisualStyleBackColor = true;
            this.btReport.Click += new System.EventHandler(this.btReport_Click);
            // 
            // frmViSao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btReport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btNhapMoi);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.cboHe);
            this.Controls.Add(this.dtNgayNhap);
            this.Controls.Add(this.txtTenVS);
            this.Controls.Add(this.txtMaVS);
            this.Controls.Add(this.dgvViSao);
            this.Name = "frmViSao";
            this.Text = "DANH MUC VI SAO";
            this.Load += new System.EventHandler(this.frmViSao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViSao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViSao;
        private System.Windows.Forms.TextBox txtMaVS;
        private System.Windows.Forms.TextBox txtTenVS;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        private System.Windows.Forms.ComboBox cboHe;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btNhapMoi;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenViSao;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHe;
        private System.Windows.Forms.Button btReport;
    }
}