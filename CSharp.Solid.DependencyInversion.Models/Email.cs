using System;

namespace CSharp.Solid.DependencyInversion.Models
{
    public class Email
    {
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public void SendEmail()
        {
            //Send email
        }
    }
}
