using System;
using System.ComponentModel.DataAnnotations;

namespace ChatAppProject.Models
{
	public class UserUpdateView
	{
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

