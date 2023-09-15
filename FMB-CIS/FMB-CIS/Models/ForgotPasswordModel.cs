﻿using System.ComponentModel.DataAnnotations;

namespace FMB_CIS.Models
{
    public class ForgotPasswordModel
    {
        //[Required, EmailAddress, Display(Name = "Registered email address")]
        [Required]
        public string email { get; set; }
        public bool emailSent { get; set; }

    }
}