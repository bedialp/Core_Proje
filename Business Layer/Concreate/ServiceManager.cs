using Business_Layer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Concreate
{
	public class ServiceManager : IServiceService
	{
		IServiceDal _serviceDal;

		public ServiceManager(IServiceDal serviceDal)
		{
			_serviceDal = serviceDal;
		}

		public void TAdd(Service t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Service t)
		{
			throw new NotImplementedException();
		}

		public Service TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<Service> TGetList()
		{
			return _serviceDal.GetList();
		}

		public List<Service> TGetListByFilter()
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Service t)
		{
			throw new NotImplementedException();
		}
	}
}
