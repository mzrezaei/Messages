using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageSender messageSender;

            List<string> list = new List<string>() { "09121234567", "myemail@yahoo.com", "09191234567", "test Message" };
            //mobile validation
            string pattern1 = @"09(1[0-9]|3[1-9]|2[1-9])-?[0-9]{3}-?[0-9]{4}";
            Regex regex1 = new Regex(pattern1);
            //email validation
            string pattern2 = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            Regex regex2 = new Regex(pattern2);
            foreach (string s in list)
            {
                bool isValid1 = regex1.IsMatch(s);
                bool isValid2 = regex2.IsMatch(s);
                if (isValid1)
                    messageSender = new SmsModel();
                else if (isValid2)
                    messageSender = new EmailModel();
                else
                    messageSender = new SystemModel();
            }

            Console.WriteLine("strategy Method");
            MessageStrategy strategy = new MessageStrategy();
            foreach (string s in list)
            {
                foreach (char c in s)
                {
                    bool isValid1 = regex1.IsMatch(s);
                    bool isValid2 = regex2.IsMatch(s);
                    if (isValid1)
                        strategy.setStrategy(new SmsModel());
                    else if (isValid2)
                        strategy.setStrategy(new EmailModel());
                    else
                        strategy.setStrategy(new SystemModel());
                    strategy.Run();
                }
                Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
