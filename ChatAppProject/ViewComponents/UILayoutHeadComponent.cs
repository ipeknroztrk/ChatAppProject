using System;
using Microsoft.AspNetCore.Mvc;

namespace ChatAppProject.ViewComponents
{
	public class UILayoutHeadComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

