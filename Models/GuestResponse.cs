﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; }

        //[Required(ErrorMessage = "Please enter your Email.")]
        [RegularExpression(@"^\S+@\S+.\S+$", ErrorMessage = "Characters are not allowed.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your Phone.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please specify whether you'll attend.")]
        public bool? WillAttend { get; set; }
    }
}
