using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Business_Layer.Concreate;

namespace Core_Proje.ViewComponents.Skill
{
	public class SkillList : ViewComponent
	{
		SkillManager skillManager = new(new EfSkillDal());
		public IViewComponentResult Invoke()
		{
			var values = skillManager.TGetList();
			return View(values);
		}
	}
}
