namespace Login
{
    partial class InFor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InFor));
            this.tb_loigioitinh = new System.Windows.Forms.Label();
            this.tb_loicancuoc = new System.Windows.Forms.Label();
            this.tb_loidiachi = new System.Windows.Forms.Label();
            this.tb_loihoten = new System.Windows.Forms.Label();
            this.bt_dangky = new System.Windows.Forms.Button();
            this.bt_chonanh = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ptB_avt = new System.Windows.Forms.PictureBox();
            this.cbB_gioitinh = new System.Windows.Forms.ComboBox();
            this.tb_cancuoc = new System.Windows.Forms.TextBox();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.tb_hoten = new System.Windows.Forms.TextBox();
            this.cb_capnhat = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptB_avt)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_loigioitinh
            // 
            this.tb_loigioitinh.AutoSize = true;
            this.tb_loigioitinh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tb_loigioitinh.ForeColor = System.Drawing.Color.Red;
            this.tb_loigioitinh.Location = new System.Drawing.Point(249, 348);
            this.tb_loigioitinh.Name = "tb_loigioitinh";
            this.tb_loigioitinh.Size = new System.Drawing.Size(174, 20);
            this.tb_loigioitinh.TabIndex = 52;
            this.tb_loigioitinh.Text = "Vui lòng chọn Giới tính !";
            // 
            // tb_loicancuoc
            // 
            this.tb_loicancuoc.AutoSize = true;
            this.tb_loicancuoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tb_loicancuoc.ForeColor = System.Drawing.Color.Red;
            this.tb_loicancuoc.Location = new System.Drawing.Point(249, 271);
            this.tb_loicancuoc.Name = "tb_loicancuoc";
            this.tb_loicancuoc.Size = new System.Drawing.Size(266, 20);
            this.tb_loicancuoc.TabIndex = 51;
            this.tb_loicancuoc.Text = "Vui lòng nhập số căn cước công dân !";
            // 
            // tb_loidiachi
            // 
            this.tb_loidiachi.AutoSize = true;
            this.tb_loidiachi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tb_loidiachi.ForeColor = System.Drawing.Color.Red;
            this.tb_loidiachi.Location = new System.Drawing.Point(249, 187);
            this.tb_loidiachi.Name = "tb_loidiachi";
            this.tb_loidiachi.Size = new System.Drawing.Size(167, 20);
            this.tb_loidiachi.TabIndex = 50;
            this.tb_loidiachi.Text = "Vui lòng nhập Địa chỉ !";
            // 
            // tb_loihoten
            // 
            this.tb_loihoten.AutoSize = true;
            this.tb_loihoten.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tb_loihoten.ForeColor = System.Drawing.Color.Red;
            this.tb_loihoten.Location = new System.Drawing.Point(249, 107);
            this.tb_loihoten.Name = "tb_loihoten";
            this.tb_loihoten.Size = new System.Drawing.Size(185, 20);
            this.tb_loihoten.TabIndex = 49;
            this.tb_loihoten.Text = "Vui lòng nhập Họ và tên !";
            // 
            // bt_dangky
            // 
            this.bt_dangky.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_dangky.Location = new System.Drawing.Point(657, 455);
            this.bt_dangky.Name = "bt_dangky";
            this.bt_dangky.Size = new System.Drawing.Size(146, 77);
            this.bt_dangky.TabIndex = 48;
            this.bt_dangky.Text = "Cập nhật";
            this.bt_dangky.UseVisualStyleBackColor = true;
            this.bt_dangky.Click += new System.EventHandler(this.bt_dangky_Click);
            // 
            // bt_chonanh
            // 
            this.bt_chonanh.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.bt_chonanh.Location = new System.Drawing.Point(622, 271);
            this.bt_chonanh.Name = "bt_chonanh";
            this.bt_chonanh.Size = new System.Drawing.Size(181, 36);
            this.bt_chonanh.TabIndex = 47;
            this.bt_chonanh.Text = "Chọn ảnh đại diện";
            this.bt_chonanh.UseVisualStyleBackColor = true;
            this.bt_chonanh.Click += new System.EventHandler(this.bt_chonanh_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(70, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 44;
            this.label7.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(70, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 41;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(70, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Căn cước";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(70, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(70, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Họ và tên";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(239, 405);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 6, 29, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(119, 27);
            this.dateTimePicker1.TabIndex = 37;
            this.dateTimePicker1.Value = new System.DateTime(2022, 6, 29, 0, 0, 0, 0);
            // 
            // ptB_avt
            // 
            this.ptB_avt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ptB_avt.Image = ((System.Drawing.Image)(resources.GetObject("ptB_avt.Image")));
            this.ptB_avt.InitialImage = null;
            this.ptB_avt.Location = new System.Drawing.Point(641, 40);
            this.ptB_avt.Name = "ptB_avt";
            this.ptB_avt.Size = new System.Drawing.Size(149, 189);
            this.ptB_avt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptB_avt.TabIndex = 34;
            this.ptB_avt.TabStop = false;
            // 
            // cbB_gioitinh
            // 
            this.cbB_gioitinh.FormattingEnabled = true;
            this.cbB_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbB_gioitinh.Location = new System.Drawing.Point(239, 310);
            this.cbB_gioitinh.Name = "cbB_gioitinh";
            this.cbB_gioitinh.Size = new System.Drawing.Size(151, 28);
            this.cbB_gioitinh.TabIndex = 33;
            this.cbB_gioitinh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbB_gioitinh_KeyDown);
            // 
            // tb_cancuoc
            // 
            this.tb_cancuoc.Location = new System.Drawing.Point(239, 225);
            this.tb_cancuoc.Name = "tb_cancuoc";
            this.tb_cancuoc.Size = new System.Drawing.Size(355, 27);
            this.tb_cancuoc.TabIndex = 32;
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(239, 146);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(355, 27);
            this.tb_diachi.TabIndex = 31;
            // 
            // tb_hoten
            // 
            this.tb_hoten.Location = new System.Drawing.Point(239, 67);
            this.tb_hoten.Name = "tb_hoten";
            this.tb_hoten.Size = new System.Drawing.Size(355, 27);
            this.tb_hoten.TabIndex = 30;
            // 
            // cb_capnhat
            // 
            this.cb_capnhat.AutoSize = true;
            this.cb_capnhat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_capnhat.Location = new System.Drawing.Point(70, 508);
            this.cb_capnhat.Name = "cb_capnhat";
            this.cb_capnhat.Size = new System.Drawing.Size(230, 24);
            this.cb_capnhat.TabIndex = 53;
            this.cb_capnhat.Text = "Tôi muốn cập nhật thông tin";
            this.cb_capnhat.UseVisualStyleBackColor = true;
            this.cb_capnhat.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // InFor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(881, 719);
            this.Controls.Add(this.cb_capnhat);
            this.Controls.Add(this.tb_loigioitinh);
            this.Controls.Add(this.tb_loicancuoc);
            this.Controls.Add(this.tb_loidiachi);
            this.Controls.Add(this.tb_loihoten);
            this.Controls.Add(this.bt_dangky);
            this.Controls.Add(this.bt_chonanh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ptB_avt);
            this.Controls.Add(this.cbB_gioitinh);
            this.Controls.Add(this.tb_cancuoc);
            this.Controls.Add(this.tb_diachi);
            this.Controls.Add(this.tb_hoten);
            this.Name = "InFor";
            this.Text = "InFor";
            ((System.ComponentModel.ISupportInitialize)(this.ptB_avt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label tb_loigioitinh;
        private Label tb_loicancuoc;
        private Label tb_loidiachi;
        private Label tb_loihoten;
        private Button bt_dangky;
        private Button bt_chonanh;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private PictureBox ptB_avt;
        private ComboBox cbB_gioitinh;
        private TextBox tb_cancuoc;
        private TextBox tb_diachi;
        private TextBox tb_hoten;
        private CheckBox cb_capnhat;
    }
}