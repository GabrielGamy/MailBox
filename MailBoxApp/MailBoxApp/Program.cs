namespace MailBoxApp
{
   class Program
   {
      static void Main(string[] args)
      {
         MailBox mailBox = new MailBox();

         Employee barack = new Employee("Barack Obama");
         Employee trudeau = new Employee("Justin Trudeau");
         Employee alpha = new Employee("Alpha cond�");

         mailBox.Email += barack.receiveEmail;
         mailBox.Email += trudeau.receiveEmail;
         mailBox.Email += alpha.receiveEmail;

         mailBox.sendNewEmail("Gabriel Gamy", "What do you do for the poor people around the world ?");
      }
   }
 }
