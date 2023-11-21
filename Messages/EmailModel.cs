using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    class EmailModel : IMessageSender
    {
        public void SendMessage(string EmailAddress, string body)
        {
            Console.WriteLine("Email\n{0}\n", body);
        }
    }
}
