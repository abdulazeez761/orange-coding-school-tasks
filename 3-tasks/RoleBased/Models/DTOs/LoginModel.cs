﻿using System.ComponentModel.DataAnnotations;

namespace RoleBased.Models.DTOs
{
    public class LoginModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}