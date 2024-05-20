﻿using Business_Layer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Concreate
{
	public class ContactManager : IContactService
	{
		IContactDal _contactDal;

		public ContactManager(IContactDal contactDal)
		{
			_contactDal = contactDal;
		}

		public void TAdd(Contact t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Contact t)
		{
			throw new NotImplementedException();
		}

		public List<Contact> TGetList()
		{
			return _contactDal.GetList();
		}

		public Contact TGetByID(int id)
		{
			return _contactDal.GetByID(id);
		}

		public void TUpdate(Contact t)
		{
			_contactDal.Update(t);
		}

		public List<Contact> TGetListbyFilter()
		{
			throw new NotImplementedException();
		}
	}
}
