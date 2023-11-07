using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Messages
{
    interface IMessageSender
    {
        void SendMessage(string Info, string body);
    }
    class MessageStrategy
    {
        public IMessageSender message { get; set; }
        public void setStrategy(IMessageSender message)
        {
            this.message = message;
        }
        public void Run()
        {
            message.SendMessage("Info", "body");
        }
    }
    class SmsSender : IMessageSender
    {
        public void SendMessage(string mobile, string body)
        {
            Console.WriteLine("Mobile\n{0}\n", body);
        }
    }
    class EmailSender : IMessageSender
    {
        public void SendMessage(string EmailAddress, string body)
        {
            Console.WriteLine("Email\n{0}\n", body);
        }
    }
    class SystemSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("SystemMessage\n{0}\n{1}\n", subject, body);
        }
    }
}
