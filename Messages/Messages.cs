using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    public class Messages
    {
        public Messages (string sms, string email, string system)
        {
            Sms = sms;
            Email = email;
            System = system;
        }
        public string Sms {  get; set; }
        public string Email {  get; set; }
        public string System {  get; set; }
    }
}


  