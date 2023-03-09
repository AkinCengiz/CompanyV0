using System;
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
    public class StreetManager : ManagerRepositoryBase<Street,EfStreetDal>,IStreetService
    {
        private IStreetDal _streetDal;

        public StreetManager(IStreetDal streetDal)
        {
            _streetDal = streetDal;
        }
    }
}
