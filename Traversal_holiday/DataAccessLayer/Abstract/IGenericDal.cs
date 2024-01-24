﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface IGenericDal<T>
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();
       List<T> GetListAllById(Expression<Func<T, bool>> filter);
        List<T> GetListAllByIdInclude(Expression<Func<T, bool>> filter);
       
        Expression<Func<T, int>> ToExpressionOfFunc(Expression<Action<T>> filters);
    }
}
