using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Uplift.Utility;

namespace Uplift.Utility
{
     internal interface IEmailSender
    {
        public class EmailSender : IEmailSender
        {
            public Task SendEmailAsync(String email, string subject, string htmlMessage)
            {
                throw new NotImplementedException();
            }
        }
    }   
}
