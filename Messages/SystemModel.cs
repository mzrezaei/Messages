using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    class SystemModel : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("SystemMessage\n{0}\n{1}\n", subject, body);
        }
    }
}
