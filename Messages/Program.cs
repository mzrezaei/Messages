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
            Console.WriteLine("Please enter your sms");
            string sms = Console.ReadLine();
            Console.WriteLine("Please enter your email address");
            string email= Console.ReadLine();
            Console.WriteLine("Please enter your system message");
            string system= Console.ReadLine();
            Messages objMessage = new Messages(sms, email, system);
        }
    }
}
