using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IGenericServices<T>
    {
        void Tadd(T t);
        void Tdelete(T t);
        void Tupdate(T t);
        List<T> TgetList();
        List<T> TgetListById(int id);
       

    }
}
