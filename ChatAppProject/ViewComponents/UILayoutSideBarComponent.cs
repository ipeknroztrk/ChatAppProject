using System;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ChatAppProject.ViewComponents
{
	public class UILayoutSideBarComponent:ViewComponent
	{
		private readonly UserManager<AppUser> _userManager;

        public UILayoutSideBarComponent(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async  Task<IViewComponentResult> InvokeAsync()
		{
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v1 = values.Image;
            ViewBag.v2 = $"{values.Name} {values.Surname}";
            return View();
		}
	}
}

