using Business_Layer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
	public class AboutController : Controller
	{

		AboutManager aboutManager = new AboutManager(new EfAboutDal());
		[HttpGet]
		public IActionResult Index()
		{
			ViewBag.v1 = "Duzenleme";
			ViewBag.v2 = "One Cikanlar";
			ViewBag.v3 = "One Cikan Sayfasi";

			var values = aboutManager.TGetByID(1);
			return View(values);
		}
		[HttpPost]
		public IActionResult Index(About about)
		{
			aboutManager.TUpdate(about);
			return RedirectToAction("Index", "Default");
		}
	}
}
