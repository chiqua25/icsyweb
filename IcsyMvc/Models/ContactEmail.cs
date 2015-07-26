using Postal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IcsyMvc.Models
{
    public class ContactEmail : Email
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SmtpFrom { get; set; }
        public string EmailFrom { get; set; }
        public string EmailTo { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public ScienceActivityEnum ProgramInterest { get; set; }
        public int Age { get; set; }
    }
}