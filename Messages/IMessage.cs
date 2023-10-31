using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    interface IMessage
    {
        void Send(string contactInfo,string content);
    }
    class Sms : IMessage
    {
        public void Send(string PhoneNumber, string content)
        {
            Console.WriteLine("Hello");
        }
      
    }
    class Email : IMessage
    {
        public void Send(string emaiAddress, string content)
        {
            Console.WriteLine("Hello");
        }
    }
    class systemMessage : IMessage
    {
        public void Send(string account, string content)
        {
            Console.WriteLine("Hello");
        }
    }
}
