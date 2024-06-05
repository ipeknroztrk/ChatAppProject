using System;
using Microsoft.AspNetCore.Mvc;

namespace ChatAppProject.ViewComponents
{
	public class UILayoutScriptComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

