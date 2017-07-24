using System;

namespace MailBoxApp
   {

   // Publisher: MailBox
   public class MailBox
   {
      private event EventHandler<EmailEventArgs> _email;

      public event EventHandler<EmailEventArgs> Email {
         add { _email += value; }
         remove { _email -= value; }
      }

      public void sendNewEmail(string sender, string message) {
         if (_email == null) return;

         if (!string.IsNullOrEmpty(sender) && !string.IsNullOrEmpty(message))
            _email.Invoke(this, new EmailEventArgs(sender, message));
      }
   }

   public class EmailEventArgs : EventArgs
   {

      public string EmailSender { get; set; }
      public string EmailMessage { get; set; }

      public EmailEventArgs(string emailSender, string emailMessage)
      {
         EmailSender = emailSender;
         EmailMessage = emailMessage;
      }
   }
}
