using Business_Layer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Experience
{
	public class ExperienceList : ViewComponent
	{
		ExperienceManager experienceManager = new(new EfExperienceDal());

		public IViewComponentResult Invoke()
		{
			var values = experienceManager.TGetList();
			return View(values);
		}
	}
}
