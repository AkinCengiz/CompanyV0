﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FenIsleri.Business.Abstract;
using FenIsleri.DataAccess.Abstract;
using FenIsleri.DataAccess.Concrete.EntityFramework;
using FenIsleri.Entities.Concrete;

namespace FenIsleri.Business.Concrete
{
    public class StaffStatuManager : ManagerRepositoryBase<StaffStatu,EfStaffStatuDal>,IStaffStatuService
    {
        private IStaffStatuDal _staffStatuDal;

        public StaffStatuManager(IStaffStatuDal staffStatuDal)
        {
            _staffStatuDal = staffStatuDal;
        }
    }
}
