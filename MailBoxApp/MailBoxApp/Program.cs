namespace MailBoxApp
{
   class Program
   {
      static void Main(string[] args)
      {
         MailBox mailBox = new MailBox();

         Employe barack = new Employe("Barack Obama");
         Employe trudeau = new Employe("Justin Trudeau");
         Employe alpha = new Employe("Alpha condé");

         mailBox.Email += barack.receiveEmail;
         mailBox.Email += trudeau.receiveEmail;
         mailBox.Email += alpha.receiveEmail;

         mailBox.sendNewEmail("Gabriel Gamy", "What do you do for the poor people around the world ?");
      }
   }
 }
