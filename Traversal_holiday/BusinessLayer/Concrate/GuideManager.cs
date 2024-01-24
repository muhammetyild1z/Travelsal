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
    public class GuideManager : IGuideService
    {
        IGuideDal _guide;

        public GuideManager(IGuideDal guide)
        {
            _guide = guide;
        }

        public void Tadd(Guide t)
        {
            throw new NotImplementedException();
        }

        public void Tdelete(Guide t)
        {
            throw new NotImplementedException();
        }

        public List<Guide> TgetList()
        {
            return _guide.GetList();
        }

        public List<Guide> TgetListById(int id)
        {
            return _guide.GetListAllById(x => x.guideId == id);
        }

        public void Tupdate(Guide t)
        {
            throw new NotImplementedException();
        }
    }
}
