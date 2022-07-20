﻿using System.ComponentModel.DataAnnotations;

namespace AssetManagement.Contracts.Request
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
