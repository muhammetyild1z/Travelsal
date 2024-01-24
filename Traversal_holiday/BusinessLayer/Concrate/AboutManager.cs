﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Tadd(About t)
        {
            _aboutDal.Insert(t);

        }

        public void Tdelete(About t)
        {
            _aboutDal.Delete(t);
        }

        public List<About> TgetById(int id)
        {
            var a=_aboutDal.GetListAllById(x => x.aboutId == id);
            return a;
           
        }

        public List<About> TgetList()
        {
            return _aboutDal.GetList();
        }

        public List<About> TgetListById(int id)
        {
            throw new NotImplementedException();
        }

        public void Tupdate(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
