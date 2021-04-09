using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Solid.DependencyInversion.Models
{
    public class Notification
    {
        private Email _email;
        private SMS _sms;
        public Notification()
        {
            _email = new Email();
            _sms = new SMS();
        }

        public void Send()
        {
            _email.SendEmail();
            _sms.SendSMS();
        }
    }
}