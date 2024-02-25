using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using System.Net;
using System.Reflection;

namespace Codewars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var fromAddress = new MailAddress("clevercoderr@gmail.com", "Muhammad Abdulloh");
            var toAddress = new MailAddress("komilovmuhammadabdulloh@gmail.com", "Senga ketyapti usha mo'ni");
            const string fromPassword = "zpnt kiyu dywx otys";
            const string subject = "Dotnet qale ketyapti";
            const string body = "bovottimi jigarim toychog'im nima gaplar";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }


    }
}
