using System;
using System.Web;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace SuetaManager.Classes
{
    class EmailHelper
    {
        public string VerificationCode { get; set; }
        public EmailHelper()
        {
            VerificationCode = GenerateCode(6);
        }
        public async Task SendEmailVerificationAsync(string emailAddress)
        {
            MailAddress from = new MailAddress("fussmanagerteam@list.ru", "Fuss Manager Team");
            MailAddress to = new MailAddress(emailAddress);
            MailMessage m = new MailMessage(from, to);
            m.Subject = "FussManager Verification Code";
            m.Body = "<p>Your FussManager verefication code is: <br><code style=\"font-size:2.5em; line-height:2em\">"+VerificationCode+"</code></p>";
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.list.ru", 587);
            smtp.Credentials = new NetworkCredential("fussmanagerteam@list.ru", "NxMjArHATpus54A");
            smtp.EnableSsl = true;
            try
            {
                await smtp.SendMailAsync(m);
                MessageBox.Show("Message was sent to your email");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public async Task SendThankMessage(string emailAddress)
        {
            MailAddress from = new MailAddress("fussmanagerteam@list.ru", "Fuss Manager Team");
            MailAddress to = new MailAddress(emailAddress);
            MailMessage m = new MailMessage(from, to);
            m.Subject = "FussManager Application";
            m.Body = "Thank you for using our application!";
            m.Attachments.Add(new Attachment(@"D:\University\Labs\Sem4\OOP\SuetaManager\SuetaManager\packages\Sprites\JackFrescoFunnyGif.gif"));
            m.Attachments.Add(new Attachment(@"D:\University\Labs\Sem4\OOP\SuetaManager\SuetaManager\packages\Sprites\Thank-You-Gif.gif"));

            SmtpClient smtp = new SmtpClient("smtp.list.ru", 587);
            smtp.Credentials = new NetworkCredential("fussmanagerteam@list.ru", "NxMjArHATpus54A");
            smtp.EnableSsl = true;
            try
            {
                await smtp.SendMailAsync(m);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private static string GenerateCode(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            for (; length > 0; length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
    }
}