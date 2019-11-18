using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace TrackerLibrary
{
  public static class EmailLogic
  {
    public static void SendEmail(string toAddresses, string subject, string body)
    {
      MailAddress fromMailAddress = new MailAddress(GlobalConfig.AppKeyLookup("senderEmail"), GlobalConfig.AppKeyLookup("displayName"));

      MailMessage mail = new MailMessage();
      mail.To.Add(toAddresses);
      mail.From = fromMailAddress;
      mail.Subject = subject;
      mail.Body = body;
      mail.IsBodyHtml = true;

      SmtpClient client = new SmtpClient();

      

      client.Send(mail);

    }
  }
}
