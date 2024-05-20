using Business_Layer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Contact
{
	public class SendMessage : ViewComponent
	{

		MessageManager messageManager = new MessageManager(new EfMessageDal());

		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
