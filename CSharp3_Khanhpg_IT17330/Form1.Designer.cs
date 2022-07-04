namespace CSharp3_Khanhpg_IT17330
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.Lb1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.BackgroundImage = global::CSharp3_Khanhpg_IT17330.Properties.Resources.ferrari_testarossa_1;
            this.button1.Location = new System.Drawing.Point(212, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 90);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nút Test";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lb1
            // 
            this.Lb1.AutoSize = true;
            this.Lb1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb1.Location = new System.Drawing.Point(312, 212);
            this.Lb1.Name = "Lb1";
            this.Lb1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lb1.Size = new System.Drawing.Size(42, 28);
            this.Lb1.TabIndex = 1;
            this.Lb1.Text = "......";
            this.Lb1.Click += new System.EventHandler(this.Lb1_Click_1);
            this.Lb1.MouseLeave += new System.EventHandler(this.Lb1_Click_1);
            this.Lb1.MouseHover += new System.EventHandler(this.Lb1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 332);
            this.Controls.Add(this.Lb1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseLeave += new System.EventHandler(this.Lb1_Click);
            this.MouseHover += new System.EventHandler(this.Lb1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label Lb1;
    }
}