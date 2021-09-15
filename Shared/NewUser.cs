﻿using System.ComponentModel.DataAnnotations;

namespace BlazorTest.Shared
{
    public class NewUser
    {
        [Required, MaxLength(50)]
        public string Name { get; set; }
        
        [Required, MinLength(3)]
        public string Username { get; set; }
        
        public string Email { get; set; }
        
        public string Password { get; set; }
    }
}