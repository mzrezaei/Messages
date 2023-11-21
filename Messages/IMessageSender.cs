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

}
