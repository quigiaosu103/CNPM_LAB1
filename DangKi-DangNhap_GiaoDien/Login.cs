using DangKi.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace DangKi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtAlertMess.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = HashPassword(txtPassword.Text);
            txtUserName.Text = password;
            if (userName != "" && password != "")
            {
                using (var context = new MyDbContext())
                {
                    var user = context.Teachers.Where(t => t.UserName == userName).FirstOrDefault();
                    if (user != null)
                    {
                        if (password == user.HashPassword)
                        {
                            
                            UserInfo.currentUser = user;
                            this.DialogResult = DialogResult.OK;
                            this.Close();

                        }
                        else
                        {
                            txtAlertMess.Show();
                        }
                    }
                    else
                    {
                        txtAlertMess.Show();
                    }
                }
            }
        }

        public static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            txtAlertMess.Hide();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtAlertMess.Hide();
        }
    }
}
