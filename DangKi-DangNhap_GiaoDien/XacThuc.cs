using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangKi
{
    class XacThuc
    {
        public void verifyCodeSender(string toEmail, string verifyCode)
        {
            string fromEmail = "phuquivo03.cb@gmail.com";
            string password = "vamp udos mbca xoxu";
            string subject = "Application verify";
            string body = "Your verify code: " + verifyCode;

            MailMessage mail = new MailMessage(fromEmail, toEmail, subject, body);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(fromEmail, password);

            try
            {
                client.Send(mail);
                MessageBox.Show("Email sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        public bool emailVerifying(string inputKey, string key)
        {
            if (key == inputKey)
            {
                return true;
            }
            return false;
        }

        public string GenerateRandomKey(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder key = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                key.Append(chars[random.Next(chars.Length)]);
            }

            return key.ToString();
        }

    }
}
