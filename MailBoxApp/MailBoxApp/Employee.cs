using System;

namespace MailBoxApp
   {

   // Consumer: Employee
   public class Employee
   {
      public string Name { get; set; }

      public Employee(string name)
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
