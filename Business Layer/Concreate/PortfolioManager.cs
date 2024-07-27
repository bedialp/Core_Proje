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
	public class PortfolioManager : IPortfolioService
	{
		IPortfolioDal _portfolioDal;

		public PortfolioManager(IPortfolioDal portfolioDal)
		{
			_portfolioDal = portfolioDal;
		}

		public void TAdd(Portfolio t)
		{
			_portfolioDal.Insert(t);
		}

		public void TDelete(Portfolio t)
		{
			_portfolioDal.Delete(t);
		}

		public Portfolio TGetByID(int id)
		{
			return _portfolioDal.GetByID(id);
		}

		public List<Portfolio> TGetList()
		{
			return _portfolioDal.GetList();
		}

		public List<Portfolio> TGetListByFilter()
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Portfolio t)
		{
			_portfolioDal.Update(t);
		}
	}
}
