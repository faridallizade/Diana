
using System.Net;
using System.Net.Mail;
using Microsoft.Identity.Client;

namespace Diana.Services
{
    public static class SendMailService
    {
        public static void SendMail()
        {
            using (var client = new SmtpClient("smtp.gmail.com", 587))
            {
                client.UseDefaultCredentials = false;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Credentials = new NetworkCredential("alizadeferid99@gmail.com", "tester");
                client.EnableSsl = true;
            }

        }
    }
}
