using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ChatAppProject.Controllers
{
    
    public class DefaultController : Controller
    { 
        private readonly UserManager<AppUser> _userManager;

        public DefaultController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }


        public UserManager<AppUser> UserManager => _userManager;

        public IActionResult Index()
        {
            return View(Index);
        }
    }
}

