namespace _0068_NguyenTranTuanAnh_Bai2
{
    partial class Form1
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
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_ThemhoacSua = new System.Windows.Forms.Button();
            this.combobox_chuyennganh = new System.Windows.Forms.ComboBox();
            this.lbl_chuyennganh = new System.Windows.Forms.Label();
            this.radiobtn_Nu = new System.Windows.Forms.RadioButton();
            this.radiobtn_Nam = new System.Windows.Forms.RadioButton();
            this.lbl_GioiTinh = new System.Windows.Forms.Label();
            this.txt_TongNam = new System.Windows.Forms.TextBox();
            this.txt_DTB = new System.Windows.Forms.TextBox();
            this.txt_TongNu = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_MSSV = new System.Windows.Forms.TextBox();
            this.lbl_DTB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.lbl_MSSV = new System.Windows.Forms.Label();
            this.lbl_ThongTin = new System.Windows.Forms.Label();
            this.ColKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(405, 427);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 37;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_ThemhoacSua
            // 
            this.btn_ThemhoacSua.Location = new System.Drawing.Point(405, 358);
            this.btn_ThemhoacSua.Name = "btn_ThemhoacSua";
            this.btn_ThemhoacSua.Size = new System.Drawing.Size(75, 23);
            this.btn_ThemhoacSua.TabIndex = 36;
            this.btn_ThemhoacSua.Text = "Thêm/Sửa";
            this.btn_ThemhoacSua.UseVisualStyleBackColor = true;
            this.btn_ThemhoacSua.Click += new System.EventHandler(this.btn_ThemhoacSua_Click);
            // 
            // combobox_chuyennganh
            // 
            this.combobox_chuyennganh.FormattingEnabled = true;
            this.combobox_chuyennganh.Items.AddRange(new object[] {
            "QTKD",
            "NGÔN NGỮ ANH",
            "CNTT"});
            this.combobox_chuyennganh.Location = new System.Drawing.Point(142, 437);
            this.combobox_chuyennganh.Name = "combobox_chuyennganh";
            this.combobox_chuyennganh.Size = new System.Drawing.Size(181, 21);
            this.combobox_chuyennganh.TabIndex = 35;
            this.combobox_chuyennganh.Text = "QTKD";
            this.combobox_chuyennganh.SelectedIndexChanged += new System.EventHandler(this.combobox_chuyennganh_SelectedIndexChanged);
            // 
            // lbl_chuyennganh
            // 
            this.lbl_chuyennganh.AutoSize = true;
            this.lbl_chuyennganh.Location = new System.Drawing.Point(54, 437);
            this.lbl_chuyennganh.Name = "lbl_chuyennganh";
            this.lbl_chuyennganh.Size = new System.Drawing.Size(76, 13);
            this.lbl_chuyennganh.TabIndex = 34;
            this.lbl_chuyennganh.Text = "Chuyên ngành";
            // 
            // radiobtn_Nu
            // 
            this.radiobtn_Nu.AutoSize = true;
            this.radiobtn_Nu.Location = new System.Drawing.Point(250, 356);
            this.radiobtn_Nu.Name = "radiobtn_Nu";
            this.radiobtn_Nu.Size = new System.Drawing.Size(39, 17);
            this.radiobtn_Nu.TabIndex = 33;
            this.radiobtn_Nu.TabStop = true;
            this.radiobtn_Nu.Text = "Nữ";
            this.radiobtn_Nu.UseVisualStyleBackColor = true;
            this.radiobtn_Nu.CheckedChanged += new System.EventHandler(this.radiobtn_Nu_CheckedChanged);
            // 
            // radiobtn_Nam
            // 
            this.radiobtn_Nam.AutoSize = true;
            this.radiobtn_Nam.Location = new System.Drawing.Point(152, 355);
            this.radiobtn_Nam.Name = "radiobtn_Nam";
            this.radiobtn_Nam.Size = new System.Drawing.Size(47, 17);
            this.radiobtn_Nam.TabIndex = 32;
            this.radiobtn_Nam.TabStop = true;
            this.radiobtn_Nam.Text = "Nam";
            this.radiobtn_Nam.UseVisualStyleBackColor = true;
            this.radiobtn_Nam.CheckedChanged += new System.EventHandler(this.radiobtn_Nam_CheckedChanged);
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.AutoSize = true;
            this.lbl_GioiTinh.Location = new System.Drawing.Point(54, 356);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(47, 13);
            this.lbl_GioiTinh.TabIndex = 31;
            this.lbl_GioiTinh.Text = "Giới tính";
            // 
            // txt_TongNam
            // 
            this.txt_TongNam.Location = new System.Drawing.Point(697, 390);
            this.txt_TongNam.Name = "txt_TongNam";
            this.txt_TongNam.Size = new System.Drawing.Size(100, 20);
            this.txt_TongNam.TabIndex = 30;
            this.txt_TongNam.TextChanged += new System.EventHandler(this.txt_TongNam_TextChanged);
            // 
            // txt_DTB
            // 
            this.txt_DTB.Location = new System.Drawing.Point(142, 386);
            this.txt_DTB.Name = "txt_DTB";
            this.txt_DTB.Size = new System.Drawing.Size(100, 20);
            this.txt_DTB.TabIndex = 29;
            this.txt_DTB.TextChanged += new System.EventHandler(this.txt_DTB_TextChanged);
            // 
            // txt_TongNu
            // 
            this.txt_TongNu.Location = new System.Drawing.Point(697, 434);
            this.txt_TongNu.Name = "txt_TongNu";
            this.txt_TongNu.Size = new System.Drawing.Size(100, 20);
            this.txt_TongNu.TabIndex = 28;
            this.txt_TongNu.TextChanged += new System.EventHandler(this.txt_TongNu_TextChanged);
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(142, 306);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(215, 20);
            this.txt_HoTen.TabIndex = 27;
            this.txt_HoTen.TextChanged += new System.EventHandler(this.txt_HoTen_TextChanged);
            // 
            // txt_MSSV
            // 
            this.txt_MSSV.Location = new System.Drawing.Point(142, 256);
            this.txt_MSSV.Name = "txt_MSSV";
            this.txt_MSSV.Size = new System.Drawing.Size(100, 20);
            this.txt_MSSV.TabIndex = 26;
            this.txt_MSSV.TextChanged += new System.EventHandler(this.txt_MSSV_TextChanged);
            // 
            // lbl_DTB
            // 
            this.lbl_DTB.AutoSize = true;
            this.lbl_DTB.Location = new System.Drawing.Point(54, 389);
            this.lbl_DTB.Name = "lbl_DTB";
            this.lbl_DTB.Size = new System.Drawing.Size(29, 13);
            this.lbl_DTB.TabIndex = 25;
            this.lbl_DTB.Text = "DTB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(599, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tổng SV Nam";
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Location = new System.Drawing.Point(50, 313);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(39, 13);
            this.lbl_HoTen.TabIndex = 22;
            this.lbl_HoTen.Text = "Họ tên";
            // 
            // lbl_MSSV
            // 
            this.lbl_MSSV.AutoSize = true;
            this.lbl_MSSV.Location = new System.Drawing.Point(50, 256);
            this.lbl_MSSV.Name = "lbl_MSSV";
            this.lbl_MSSV.Size = new System.Drawing.Size(67, 13);
            this.lbl_MSSV.TabIndex = 21;
            this.lbl_MSSV.Text = "Mã sinh viên";
            // 
            // lbl_ThongTin
            // 
            this.lbl_ThongTin.AutoSize = true;
            this.lbl_ThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThongTin.Location = new System.Drawing.Point(254, 35);
            this.lbl_ThongTin.Name = "lbl_ThongTin";
            this.lbl_ThongTin.Size = new System.Drawing.Size(326, 29);
            this.lbl_ThongTin.TabIndex = 20;
            this.lbl_ThongTin.Text = "Quản Lý Thông Tin Sinh Viên";
            // 
            // ColKhoa
            // 
            this.ColKhoa.HeaderText = "Khoa";
            this.ColKhoa.Name = "ColKhoa";
            // 
            // ColDTB
            // 
            this.ColDTB.HeaderText = "DTB";
            this.ColDTB.Name = "ColDTB";
            // 
            // ColGioiTinh
            // 
            this.ColGioiTinh.HeaderText = "Giới Tính";
            this.ColGioiTinh.Name = "ColGioiTinh";
            // 
            // ColHoTen
            // 
            this.ColHoTen.HeaderText = "Họ Tên";
            this.ColHoTen.Name = "ColHoTen";
            // 
            // ColMSSV
            // 
            this.ColMSSV.HeaderText = "MSSV";
            this.ColMSSV.Name = "ColMSSV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(599, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tổng SV Nữ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMSSV,
            this.ColHoTen,
            this.ColGioiTinh,
            this.ColDTB,
            this.ColKhoa});
            this.dataGridView1.Location = new System.Drawing.Point(304, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(502, 150);
            this.dataGridView1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 492);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_ThemhoacSua);
            this.Controls.Add(this.combobox_chuyennganh);
            this.Controls.Add(this.lbl_chuyennganh);
            this.Controls.Add(this.radiobtn_Nu);
            this.Controls.Add(this.radiobtn_Nam);
            this.Controls.Add(this.lbl_GioiTinh);
            this.Controls.Add(this.txt_TongNam);
            this.Controls.Add(this.txt_DTB);
            this.Controls.Add(this.txt_TongNu);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.txt_MSSV);
            this.Controls.Add(this.lbl_DTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_HoTen);
            this.Controls.Add(this.lbl_MSSV);
            this.Controls.Add(this.lbl_ThongTin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_ThemhoacSua;
        private System.Windows.Forms.ComboBox combobox_chuyennganh;
        private System.Windows.Forms.Label lbl_chuyennganh;
        private System.Windows.Forms.RadioButton radiobtn_Nu;
        private System.Windows.Forms.RadioButton radiobtn_Nam;
        private System.Windows.Forms.Label lbl_GioiTinh;
        private System.Windows.Forms.TextBox txt_TongNam;
        private System.Windows.Forms.TextBox txt_DTB;
        private System.Windows.Forms.TextBox txt_TongNu;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_MSSV;
        private System.Windows.Forms.Label lbl_DTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.Label lbl_MSSV;
        private System.Windows.Forms.Label lbl_ThongTin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMSSV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

