using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


//Jeff Peerson  - CSharp230 - Assignment 1

namespace BirthdayCard.Models
{
    public class BirthdayCard
    {
        [Required(ErrorMessage = "Please enter From.")]
        public string From { get; set; }

        [Required(ErrorMessage = "Please enter To.")]
        public string To { get; set; }

        [Required(ErrorMessage = "Please enter a Message.")]
        public string Message { get; set; }

        public bool Complete
        {
            get
            {
                return !string.IsNullOrEmpty(From) && !string.IsNullOrEmpty(To) && !string.IsNullOrEmpty(Message);
            }
        }

    }
}
