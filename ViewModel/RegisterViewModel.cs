﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TourBase_Stage_1_2.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Рік народження")]
        public int Year { get; set; }

        [Required]
        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Паролі не співпадають")]
        [Display(Name = "Підтвердження паролю")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }
    }
}
