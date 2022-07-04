namespace CSharp3_Khanhpg_IT17330
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.Show();
            button1.Text = "Đã ấn nút";
            MessageBox.Show("Xin chào các bạn");
            button1.ForeColor = System.Drawing.Color.Red;
        }
        private void Lb1_Click(object sender, EventArgs e)
        {
            Lb1.Text = "abc";
        }
        private void Lb1_Click_1(object sender, EventArgs e)
        {
            Lb1.Text = "lk";
        }
    }
}