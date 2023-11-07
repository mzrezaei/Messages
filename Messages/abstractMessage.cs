using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    abstract class abstractMessage :IMessageSender
    {
        //public string Subject { get; set; }
        //public string Body { get; set; }
        //public abstract void Send();

        public void SendMessage(string Info, string body)
        {
            throw new NotImplementedException();
        }
    }
    
    //public class EmailSender : abstractMessage
    //{
    //    public override void Send(string EmailAddress,string subject, string body)
    //    {
    //        Console.WriteLine("Email\n{0}\n{1}\n", subject, body);
    //    }

    //}
    
    //public class SystemSender 
    //{
    //    public void SendMessage(string subject, string body)
    //    {
    //        Console.WriteLine("SystemMessage\n{0}\n{1}\n", subject, body);
    //    }
    //}

}





  