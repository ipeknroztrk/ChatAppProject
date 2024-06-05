using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EFAppUserDAL : GenericRepository<AppUser>, IAppUserDAL
    {

        //private readonly UserManager<AppUser> _userManager;

        //public EFAppUserDAL(Context context, UserManager<AppUser> userManager) : base(context)
        // {
        //      _userManager = userManager;
        // }
        public EFAppUserDAL(Context context) : base(context)
        {
        }
    }
}

