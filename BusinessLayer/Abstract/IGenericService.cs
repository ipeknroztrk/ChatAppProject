using System;
namespace BusinessLayer.Abstract
{
	public interface IGenericService<T>

	{
		void TAdd(T t);
		void TDelete(int id);
		void TUpdate(T t);
		List<T> TGetList();
		T TGetById(int id);
        List<T> TGetAll();
    }
}

