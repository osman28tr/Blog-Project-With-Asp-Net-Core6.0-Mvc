﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDal _porfolioDal;
        public PortfolioManager(IPortfolioDal porfolioDal)
        {
            _porfolioDal = porfolioDal;
        }

        public void TAdd(Portfolio t)
        {
            _porfolioDal.Insert(t);
        }

        public void TDelete(Portfolio t)
        {
            _porfolioDal.Delete(t);
        }

        public Portfolio TGetById(int id)
        {
            return _porfolioDal.GetById(id);
        }

        public List<Portfolio> TGetList()
        {
            return _porfolioDal.GetList();
        }

        public void TUpdate(Portfolio t)
        {
            _porfolioDal.Update(t);
        }
    }
}
