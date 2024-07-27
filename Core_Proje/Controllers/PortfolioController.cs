﻿using Business_Layer.Concreate;
using Business_Layer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
	public class PortfolioController : Controller
	{
		PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
		public IActionResult Index()
		{
			ViewBag.v1 = "Proje Listesi";
			ViewBag.v2 = "Projeler";
			ViewBag.v3 = "Proje Listesi";
			var values = portfolioManager.TGetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddPortfolio()
		{
			ViewBag.v1 = "Proje Ekle";
			ViewBag.v2 = "Projeler";
			ViewBag.v3 = "Proje Ekle";
			return View();
		}

		[HttpPost]
		public IActionResult AddPortfolio(Portfolio p)
		{
			PortfolioValidator validations = new PortfolioValidator();
			ValidationResult result = validations.Validate(p);
			if (result.IsValid)
			{
				portfolioManager.TAdd(p);
				return RedirectToAction("Index");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
				return View();
			}
		}

		public IActionResult DeletePortfolio(int id)
		{
			var values = portfolioManager.TGetByID(id);
			portfolioManager.TDelete(values);
			return RedirectToAction("Index");
		}
		public IActionResult EditPortfolio(int id)
		{
			ViewBag.v1 = "Proje Güncelle";
			ViewBag.v2 = "Projeler";
			ViewBag.v3 = "Proje Güncelle";
			var values = portfolioManager.TGetByID(id);
			return View(values);
		}

		[HttpPost]
		public IActionResult EditPortfolio(Portfolio p)
		{

			PortfolioValidator validations = new PortfolioValidator();
			ValidationResult results = validations.Validate(p);
			if (results.IsValid)
			{
				portfolioManager.TUpdate(p);
				return RedirectToAction("Index");
			}
			else
			{
				foreach (var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
		}
	}
}
