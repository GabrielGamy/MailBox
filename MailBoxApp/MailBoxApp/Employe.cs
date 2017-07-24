using System;

namespace MailBoxApp
   {

   // Consumer: Employe
   public class Employe
   {
      public string Name { get; set; }

      public Employe(string name)
      {
         Name = name;
      }

      public void receiveEmail(object mailBox, EmailEventArgs emailInfo)
      {
         Console.WriteLine("Email for: " + this.Name);
         Console.WriteLine("From: " + emailInfo.EmailSender);
         Console.WriteLine("Message: " + emailInfo.EmailMessage + "\n");
      }
   }
}
