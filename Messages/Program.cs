using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageSender messageSender;
        
            List<string> list = new List<string>() {"09121234567","myemail@yahoo.com", "09191234567", "test Message" };
            foreach (string s in list)
            {
                
                foreach(char c in s)
                {
                    if (c >= '0' && c <= '9' && s.Length == 11)
                        messageSender = new SmsSender();
                    else if(s.LastIndexOf(".") > s.LastIndexOf("@"))
                        messageSender = new EmailSender();
                    else
                        messageSender = new SystemSender();
                }
                
            }
            
            Console.WriteLine("strategy Method");
            MessageStrategy strategy = new MessageStrategy();
            foreach (string s in list)
            {
                foreach (char c in s)
                {
                    if (c >= '0' && c <= '9' && s.Length == 11)
                        strategy.setStrategy(new SmsSender());
                    else if(s.LastIndexOf(".") > s.LastIndexOf("@"))
                        strategy.setStrategy(new EmailSender());
                    else
                        strategy.setStrategy(new SystemSender());
                    strategy.Run();
                }
                Console.ReadLine();
            }
            //IMessageSender email = new EmailSender();
            //IMessageSender sms = new SMSSender();
            //IMessageSender web = new SystemSender();

            //Message message = new SystemMessage();
            //message.Subject = "Test Message";
            //message.Body = "Hi, This is a Test Message";

            //message.MessageSender = email;
            //message.Send();

            //message.MessageSender = sms;
            //message.Send();

            //message.MessageSender = web;
            //message.Send();

            //UserMessage usermsg = new UserMessage();
            //usermsg.Subject = "Test Message";
            //usermsg.Body = "Hi, This is a Test Message";
            //usermsg.UserComments = "I hope you are well";

            //usermsg.MessageSender = email;
            //usermsg.Send();

            Console.ReadKey();
        }
    }
}
