using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IcsyMvc.Models
{
    public class ContactFormModel
    {
        //contact form fields
        [Required, Display(Name = "First Name")]
        public string FromFirstName { get; set; }
        [Required, Display(Name = "Last Name")]
        public string FromLastName { get; set; }
        [Required, Display(Name = "Email"), EmailAddress]
        public string FromEmail { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
        public string Page { get; set; }

        //membership form fields
        [Required, Display(Name = "Programs of Interest")]
        public ScienceActivityEnum Programs { get; set; }
        public int? Age { get; set; }

        //verification field
        [Required, Display(Name = "Enter two digit number with no space")]
        public int? FormVerification { get; set; }
    }
}