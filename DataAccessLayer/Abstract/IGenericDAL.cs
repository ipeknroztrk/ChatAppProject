using System;
using System.Linq.Expressions;

namespace DataAccessLayer.Abstract
{
	public interface IGenericDAL<T>
	{
        void Insert(T t);
        void Delete(int id);
        void Update(T t);
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T GetById(int id);
        List<T> GetAll();

    }
}
	

