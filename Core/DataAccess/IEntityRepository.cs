using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class , IEntity, new()
    {
        //Generic Constraint
        //Class : Referans tip olabilir demek.(Class olabilir demek değil.)
        //IEntity: IEntity olabilir veya IEntity iplemente eden bir nesne olabilir.
        //new(): New'lenebilir olmalı.

        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
