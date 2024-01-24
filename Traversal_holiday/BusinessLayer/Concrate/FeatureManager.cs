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
  public  class FeatureManager:IFeatureService
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void Tadd(Feature t)
        {
            throw new NotImplementedException();
        }

        public void Tdelete(Feature t)
        {
            throw new NotImplementedException();
        }

        public Feature TgetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature> TgetList()
        {
            return _featureDal.GetList();
        }

        public List<Feature> TgetListById(int id)
        {
            throw new NotImplementedException();
        }

        public void Tupdate(Feature t)
        {
            throw new NotImplementedException();
        }
    }
}
