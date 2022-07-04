namespace Login
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.tb_hoten = new System.Windows.Forms.TextBox();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.tb_cancuoc = new System.Windows.Forms.TextBox();
            this.cbB_gioitinh = new System.Windows.Forms.ComboBox();
            this.ptB_avt = new System.Windows.Forms.PictureBox();
            this.tb_tenDN = new System.Windows.Forms.TextBox();
            this.tb_matkhauDN = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_nhaplaiMK = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_chonanh = new System.Windows.Forms.Button();
            this.bt_dangky = new System.Windows.Forms.Button();
            this.tb_loihoten = new System.Windows.Forms.Label();
            this.tb_loidiachi = new System.Windows.Forms.Label();
            this.tb_loicancuoc = new System.Windows.Forms.Label();
            this.tb_loigioitinh = new System.Windows.Forms.Label();
            this.tb_loimatkhau = new System.Windows.Forms.Label();
            this.tb_loitenDN = new System.Windows.Forms.Label();
            this.tb_loinhaplaiMK = new System.Windows.Forms.Label();
            this.tb_loimkkhongchung = new System.Windows.Forms.Label();
            this.cb_hienmk = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptB_avt)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_hoten
            // 
            this.tb_hoten.Location = new System.Drawing.Point(211, 69);
            this.tb_hoten.Name = "tb_hoten";
            this.tb_hoten.Size = new System.Drawing.Size(355, 27);
            this.tb_hoten.TabIndex = 0;
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(211, 148);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(355, 27);
            this.tb_diachi.TabIndex = 1;
            // 
            // tb_cancuoc
            // 
            this.tb_cancuoc.Location = new System.Drawing.Point(211, 227);
            this.tb_cancuoc.Name = "tb_cancuoc";
            this.tb_cancuoc.Size = new System.Drawing.Size(355, 27);
            this.tb_cancuoc.TabIndex = 2;
            // 
            // cbB_gioitinh
            // 
            this.cbB_gioitinh.FormattingEnabled = true;
            this.cbB_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbB_gioitinh.Location = new System.Drawing.Point(211, 312);
            this.cbB_gioitinh.Name = "cbB_gioitinh";
            this.cbB_gioitinh.Size = new System.Drawing.Size(151, 28);
            this.cbB_gioitinh.TabIndex = 3;
            this.cbB_gioitinh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbB_gioitinh_KeyDown);
            // 
            // ptB_avt
            // 
            this.ptB_avt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ptB_avt.Image = ((System.Drawing.Image)(resources.GetObject("ptB_avt.Image")));
            this.ptB_avt.InitialImage = null;
            this.ptB_avt.Location = new System.Drawing.Point(613, 42);
            this.ptB_avt.Name = "ptB_avt";
            this.ptB_avt.Size = new System.Drawing.Size(149, 189);
            this.ptB_avt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptB_avt.TabIndex = 4;
            this.ptB_avt.TabStop = false;
            // 
            // tb_tenDN
            // 
            this.tb_tenDN.Location = new System.Drawing.Point(211, 386);
            this.tb_tenDN.Name = "tb_tenDN";
            this.tb_tenDN.Size = new System.Drawing.Size(355, 27);
            this.tb_tenDN.TabIndex = 5;
            // 
            // tb_matkhauDN
            // 
            this.tb_matkhauDN.Location = new System.Drawing.Point(211, 464);
            this.tb_matkhauDN.Name = "tb_matkhauDN";
            this.tb_matkhauDN.PasswordChar = '*';
            this.tb_matkhauDN.Size = new System.Drawing.Size(355, 27);
            this.tb_matkhauDN.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(211, 653);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 6, 29, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(119, 27);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2022, 6, 29, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(42, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(42, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Căn cước";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(42, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(42, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tên Đăng nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(42, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mật khẩu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(42, 655);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ngày sinh";
            // 
            // tb_nhaplaiMK
            // 
            this.tb_nhaplaiMK.Location = new System.Drawing.Point(211, 573);
            this.tb_nhaplaiMK.Name = "tb_nhaplaiMK";
            this.tb_nhaplaiMK.PasswordChar = '*';
            this.tb_nhaplaiMK.Size = new System.Drawing.Size(355, 27);
            this.tb_nhaplaiMK.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(42, 575);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nhập lại mật khẩu";
            // 
            // bt_chonanh
            // 
            this.bt_chonanh.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.bt_chonanh.Location = new System.Drawing.Point(594, 273);
            this.bt_chonanh.Name = "bt_chonanh";
            this.bt_chonanh.Size = new System.Drawing.Size(181, 36);
            this.bt_chonanh.TabIndex = 17;
            this.bt_chonanh.Text = "Chọn ảnh đại diện";
            this.bt_chonanh.UseVisualStyleBackColor = true;
            this.bt_chonanh.Click += new System.EventHandler(this.bt_chonanh_Click);
            // 
            // bt_dangky
            // 
            this.bt_dangky.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_dangky.Location = new System.Drawing.Point(616, 534);
            this.bt_dangky.Name = "bt_dangky";
            this.bt_dangky.Size = new System.Drawing.Size(146, 77);
            this.bt_dangky.TabIndex = 18;
            this.bt_dangky.Text = "Đăng ký";
            this.bt_dangky.UseVisualStyleBackColor = true;
            this.bt_dangky.Click += new System.EventHandler(this.bt_dangky_Click);
            // 
            // tb_loihoten
            // 
            this.tb_loihoten.AutoSize = true;
            this.tb_loihoten.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tb_loihoten.ForeColor = System.Drawing.Color.Red;
            this.tb_loihoten.Location = new System.Drawing.Point(221, 109);
            this.tb_loihoten.Name = "tb_loihoten";
            this.tb_loihoten.Size = new System.Drawing.Size(185, 20);
            this.tb_loihoten.TabIndex = 19;
            this.tb_loihoten.Text = "Vui lòng nhập Họ và tên !";
            // 
            // tb_loidiachi
            // 
            this.tb_loidiachi.AutoSize = true;
            this.tb_loidiachi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tb_loidiachi.ForeColor = System.Drawing.Color.Red;
            this.tb_loidiachi.Location = new System.Drawing.Point(221, 189);
            this.tb_loidiachi.Name = "tb_loidiachi";
            this.tb_loidiachi.Size = new System.Drawing.Size(167, 20);
            this.tb_loidiachi.TabIndex = 20;
            this.tb_loidiachi.Text = "Vui lòng nhập Địa chỉ !";
            // 
            // tb_loicancuoc
            // 
            this.tb_loicancuoc.AutoSize = true;
            this.tb_loicancuoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tb_loicancuoc.ForeColor = System.Drawing.Color.Red;
            this.tb_loicancuoc.Location = new System.Drawing.Point(221, 273);
            this.tb_loicancuoc.Name = "tb_loicancuoc";
            this.tb_loicancuoc.Size = new System.Drawing.Size(266, 20);
            this.tb_loicancuoc.TabIndex = 21;
            this.tb_loicancuoc.Text = "Vui lòng nhập số căn cước công dân !";
            // 
            // tb_loigioitinh
            // 
            this.tb_loigioitinh.AutoSize = true;
            this.tb_loigioitinh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tb_loigioitinh.ForeColor = System.Drawing.Color.Red;
            this.tb_loigioitinh.Location = new System.Drawing.Point(221, 350);
            this.tb_loigioitinh.Name = "tb_loigioitinh";
            this.tb_loigioitinh.Size = new System.Drawing.Size(174, 20);
            this.tb_loigioitinh.TabIndex = 22;
            this.tb_loigioitinh.Text = "Vui lòng chọn Giới tính !";
            // 
            // tb_loimatkhau
            // 
            this.tb_loimatkhau.AutoSize = true;
            this.tb_loimatkhau.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tb_loimatkhau.ForeColor = System.Drawing.Color.Red;
            this.tb_loimatkhau.Location = new System.Drawing.Point(221, 507);
            this.tb_loimatkhau.Name = "tb_loimatkhau";
            this.tb_loimatkhau.Size = new System.Drawing.Size(185, 20);
            this.tb_loimatkhau.TabIndex = 23;
            this.tb_loimatkhau.Text = "Vui lòng nhập Mật khẩu !";
            // 
            // tb_loitenDN
            // 
            this.tb_loitenDN.AutoSize = true;
            this.tb_loitenDN.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tb_loitenDN.ForeColor = System.Drawing.Color.Red;
            this.tb_loitenDN.Location = new System.Drawing.Point(221, 429);
            this.tb_loitenDN.Name = "tb_loitenDN";
            this.tb_loitenDN.Size = new System.Drawing.Size(224, 20);
            this.tb_loitenDN.TabIndex = 24;
            this.tb_loitenDN.Text = "Vui lòng nhập Tên đăng nhập !";
            // 
            // tb_loinhaplaiMK
            // 
            this.tb_loinhaplaiMK.AutoSize = true;
            this.tb_loinhaplaiMK.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tb_loinhaplaiMK.ForeColor = System.Drawing.Color.Red;
            this.tb_loinhaplaiMK.Location = new System.Drawing.Point(229, 618);
            this.tb_loinhaplaiMK.Name = "tb_loinhaplaiMK";
            this.tb_loinhaplaiMK.Size = new System.Drawing.Size(206, 20);
            this.tb_loinhaplaiMK.TabIndex = 25;
            this.tb_loinhaplaiMK.Text = "Vui lòng nhập lại mật khẩu !";
            // 
            // tb_loimkkhongchung
            // 
            this.tb_loimkkhongchung.AutoSize = true;
            this.tb_loimkkhongchung.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tb_loimkkhongchung.ForeColor = System.Drawing.Color.Red;
            this.tb_loimkkhongchung.Location = new System.Drawing.Point(221, 618);
            this.tb_loimkkhongchung.Name = "tb_loimkkhongchung";
            this.tb_loimkkhongchung.Size = new System.Drawing.Size(277, 20);
            this.tb_loimkkhongchung.TabIndex = 26;
            this.tb_loimkkhongchung.Text = "Mật khẩu của bạn không không khớp !";
            // 
            // cb_hienmk
            // 
            this.cb_hienmk.AutoSize = true;
            this.cb_hienmk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cb_hienmk.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_hienmk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cb_hienmk.Location = new System.Drawing.Point(221, 534);
            this.cb_hienmk.Name = "cb_hienmk";
            this.cb_hienmk.Size = new System.Drawing.Size(131, 24);
            this.cb_hienmk.TabIndex = 27;
            this.cb_hienmk.Text = "Hiện mật khẩu";
            this.cb_hienmk.UseVisualStyleBackColor = false;
            this.cb_hienmk.CheckedChanged += new System.EventHandler(this.cb_hienmk_CheckedChanged);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(807, 759);
            this.Controls.Add(this.cb_hienmk);
            this.Controls.Add(this.tb_loimkkhongchung);
            this.Controls.Add(this.tb_loinhaplaiMK);
            this.Controls.Add(this.tb_loitenDN);
            this.Controls.Add(this.tb_loimatkhau);
            this.Controls.Add(this.tb_loigioitinh);
            this.Controls.Add(this.tb_loicancuoc);
            this.Controls.Add(this.tb_loidiachi);
            this.Controls.Add(this.tb_loihoten);
            this.Controls.Add(this.bt_dangky);
            this.Controls.Add(this.bt_chonanh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_nhaplaiMK);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tb_matkhauDN);
            this.Controls.Add(this.tb_tenDN);
            this.Controls.Add(this.ptB_avt);
            this.Controls.Add(this.cbB_gioitinh);
            this.Controls.Add(this.tb_cancuoc);
            this.Controls.Add(this.tb_diachi);
            this.Controls.Add(this.tb_hoten);
            this.Name = "SignUp";
            this.Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)(this.ptB_avt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_hoten;
        private TextBox tb_diachi;
        private TextBox tb_cancuoc;
        private ComboBox cbB_gioitinh;
        private PictureBox ptB_avt;
        private TextBox tb_tenDN;
        private TextBox tb_matkhauDN;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tb_nhaplaiMK;
        private Label label8;
        private Button bt_chonanh;
        private Button bt_dangky;
        private Label tb_loihoten;
        private Label tb_loidiachi;
        private Label tb_loicancuoc;
        private Label tb_loigioitinh;
        private Label tb_loimatkhau;
        private Label tb_loitenDN;
        private Label tb_loinhaplaiMK;
        private Label tb_loimkkhongchung;
        private CheckBox cb_hienmk;
    }
}