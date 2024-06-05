using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AppUserManager : IAppUserService
    {
        IAppUserDAL _appUserDAL;

        public AppUserManager(IAppUserDAL appUserDAL)
        {
            _appUserDAL = appUserDAL;
        }

        public void TAdd(AppUser t)
        {
            _appUserDAL.Insert(t);
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> TGetAll()
        {
            return _appUserDAL.GetAll();
        }

        public AppUser TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(AppUser t)
        {
            throw new NotImplementedException();
        }
    }
}

