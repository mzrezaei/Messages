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
        //new tuple
        public (int value, string Name) SetTuple()
        {
            (int value, string Name) newTuple = (10, "");
            newTuple.value = 1;
            return newTuple;
        }
        //old tuple which has readonly properties
        public Tuple<int, string, int> OldTuple = new Tuple<int, string, int>(10, "test", 40);
        
    }
}
