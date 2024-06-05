using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        private Context context;

        public GenericRepository(Context context)
        {
            this.context = context;
        }

        public void Delete(int id)
        {
            using var c = new Context();
            var entity = c.Set<T>().Find(id);
            c.Set<T>().Remove(entity);
            c.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
        }




        public List<T> GetList()
        {
            return context.Set<T>().ToList();
        }

        public List<T> GetList(Expression<Func<T, bool>> filter)
        {
            return context.Set<T>().Where(filter).ToList();
        }



        public void Insert(T t)
        {
            using var c = new Context();
            c.Set<T>().Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new Context();
            c.Set<T>().Update(t);
            c.SaveChanges();
        }
    }
}
