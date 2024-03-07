namespace DangKi
{
    public partial class Dangki : Form
    {
        string key;
        public Dangki()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == txtPass2.Text)
            {
                if (txtCode.Text.Length > 0 && txtCode.Text == key)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Verify code fail");
                }
            }
            else
            {
                MessageBox.Show("Password not same");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            XacThuc xacThuc = new XacThuc();
            key = xacThuc.GenerateRandomKey(6);
            xacThuc.verifyCodeSender(txtEmail.Text, key);

        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            
           
        }
    }
}
