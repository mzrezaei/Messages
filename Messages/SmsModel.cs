using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    class SmsModel : IMessageSender
    {
        public void SendMessage(string mobile, string body)
        {

            Console.WriteLine("Mobile\n{0}\n", body);
        }
    }
}
