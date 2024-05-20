using Business_Layer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Contact
{
	public class ContactDetails : ViewComponent
	{
		ContactManager contactManager = new(new EfContactDal());
		public IViewComponentResult Invoke()
		{
			var values = contactManager.TGetList();
			return View(values);
		}
	}
}
