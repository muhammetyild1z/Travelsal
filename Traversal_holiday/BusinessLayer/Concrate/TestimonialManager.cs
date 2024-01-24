using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
  public  class TestimonialManager:ITestiMonialService
    {
        ITestiMonialDal _TestiMonial;

        public TestimonialManager(ITestiMonialDal testiMonial)
        {
            _TestiMonial = testiMonial;
        }

        public void Tadd(TestiMonial t)
        {
            throw new NotImplementedException();
        }

        public void Tdelete(TestiMonial t)
        {
            throw new NotImplementedException();
        }

        public TestiMonial TgetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<TestiMonial> TgetList()
        {
            return _TestiMonial.GetList().Take(4).ToList() ;
        }

        public List<TestiMonial> TgetListById(int id)
        {
            throw new NotImplementedException();
        }

        public void Tupdate(TestiMonial t)
        {
            throw new NotImplementedException();
        }
    }
}
