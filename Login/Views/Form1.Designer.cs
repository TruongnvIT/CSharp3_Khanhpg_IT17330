namespace Login
{
    partial class Login1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tB_tenDN1 = new System.Windows.Forms.TextBox();
            this.tB_matkhauDN1 = new System.Windows.Forms.TextBox();
            this.cB_nguoimay = new System.Windows.Forms.CheckBox();
            this.bT_DN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lB_quenMK = new System.Windows.Forms.Label();
            this.lb_DK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tB_tenDN1
            // 
            this.tB_tenDN1.Location = new System.Drawing.Point(217, 63);
            this.tB_tenDN1.Name = "tB_tenDN1";
            this.tB_tenDN1.Size = new System.Drawing.Size(379, 27);
            this.tB_tenDN1.TabIndex = 0;
            // 
            // tB_matkhauDN1
            // 
            this.tB_matkhauDN1.Location = new System.Drawing.Point(217, 165);
            this.tB_matkhauDN1.Name = "tB_matkhauDN1";
            this.tB_matkhauDN1.PasswordChar = '*';
            this.tB_matkhauDN1.Size = new System.Drawing.Size(379, 27);
            this.tB_matkhauDN1.TabIndex = 1;
            // 
            // cB_nguoimay
            // 
            this.cB_nguoimay.AutoSize = true;
            this.cB_nguoimay.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cB_nguoimay.Location = new System.Drawing.Point(217, 275);
            this.cB_nguoimay.Name = "cB_nguoimay";
            this.cB_nguoimay.Size = new System.Drawing.Size(233, 27);
            this.cB_nguoimay.TabIndex = 2;
            this.cB_nguoimay.Text = "Tôi không phải người máy";
            this.cB_nguoimay.UseVisualStyleBackColor = true;
            // 
            // bT_DN
            // 
            this.bT_DN.BackColor = System.Drawing.Color.Cyan;
            this.bT_DN.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bT_DN.ForeColor = System.Drawing.Color.Green;
            this.bT_DN.Location = new System.Drawing.Point(106, 339);
            this.bT_DN.Name = "bT_DN";
            this.bT_DN.Size = new System.Drawing.Size(159, 45);
            this.bT_DN.TabIndex = 3;
            this.bT_DN.Text = "Đăng nhập";
            this.bT_DN.UseVisualStyleBackColor = false;
            this.bT_DN.Click += new System.EventHandler(this.bT_DN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu";
            // 
            // lB_quenMK
            // 
            this.lB_quenMK.AutoSize = true;
            this.lB_quenMK.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lB_quenMK.ForeColor = System.Drawing.Color.Red;
            this.lB_quenMK.Location = new System.Drawing.Point(217, 217);
            this.lB_quenMK.Name = "lB_quenMK";
            this.lB_quenMK.Size = new System.Drawing.Size(116, 20);
            this.lB_quenMK.TabIndex = 6;
            this.lB_quenMK.Text = "Quên mật khẩu";
            this.lB_quenMK.Click += new System.EventHandler(this.lB_quenMK_Click);
            // 
            // lb_DK
            // 
            this.lb_DK.AutoSize = true;
            this.lb_DK.Font = new System.Drawing.Font("Cambria", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_DK.ForeColor = System.Drawing.Color.Black;
            this.lb_DK.Location = new System.Drawing.Point(395, 351);
            this.lb_DK.Name = "lb_DK";
            this.lb_DK.Size = new System.Drawing.Size(290, 21);
            this.lb_DK.TabIndex = 7;
            this.lb_DK.Text = "Chưa có tài khoản > ĐĂNG KÝ ngay";
            this.lb_DK.Click += new System.EventHandler(this.lb_DK_Click);
            this.lb_DK.MouseLeave += new System.EventHandler(this.lb_DK_MouseLeave);
            this.lb_DK.MouseHover += new System.EventHandler(this.lb_DK_MouseHover);
            // 
            // Login1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(773, 461);
            this.Controls.Add(this.lb_DK);
            this.Controls.Add(this.lB_quenMK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bT_DN);
            this.Controls.Add(this.cB_nguoimay);
            this.Controls.Add(this.tB_matkhauDN1);
            this.Controls.Add(this.tB_tenDN1);
            this.Name = "Login1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tB_tenDN1;
        private TextBox tB_matkhauDN1;
        private CheckBox cB_nguoimay;
        private Button bT_DN;
        private Label label1;
        private Label label2;
        private Label lB_quenMK;
        private Label lb_DK;
    }
}