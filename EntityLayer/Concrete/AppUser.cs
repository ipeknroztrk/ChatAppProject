using System;
using Microsoft.AspNetCore.Identity;

namespace EntityLayer.Concrete
{
	public class AppUser:IdentityUser<int>
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string? Image { get; set; }
		public string? Email { get; set; }

		public List<Message> Senders { get; set; }
        public List<Message> Receivers { get; set; }
        
    }
}

