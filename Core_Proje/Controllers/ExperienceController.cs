﻿using Business_Layer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
	public class ExperienceController : Controller
	{
		ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
		public IActionResult Index()
		{
			ViewBag.v1 = "Deneyim Listesi";
			ViewBag.v2 = "Deneyimler";
			ViewBag.v3 = "Deneyim Listesi";
			var values = experienceManager.TGetList();
			return View(values);
		}

		[HttpGet]
		public IActionResult AddExperience()
		{
			ViewBag.v1 = "Deneyim Ekle";
			ViewBag.v2 = "Deneyimler";
			ViewBag.v3 = "Deneyim Ekle";
			return View();
		}
		[HttpPost]
		public IActionResult AddExperience(Experience experience)
		{
			experienceManager.TAdd(experience);
			return RedirectToAction("Index");
		}
		public IActionResult DeleteExperience(int id)
		{
			var values = experienceManager.TGetByID(id);
			experienceManager.TDelete(values);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult EditExperience(int id)
		{
			ViewBag.v1 = "Deneyim Duzenle";
			ViewBag.v2 = "Deneyimler";
			ViewBag.v3 = "Deneyim Duzenle";
			var values = experienceManager.TGetByID(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult EditExperience(Experience experience)
		{
			experienceManager.TUpdate(experience);
			return RedirectToAction("Index");
		}
	}
}
