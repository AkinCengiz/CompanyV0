using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FenIsleri.DataAccess.Abstract;
using FenIsleri.Entities.Concrete;

namespace FenIsleri.DataAccess.Concrete.EntityFramework
{
    public class EfRegionDal : EfEntityRepositoryBase<Region,FenIsleriContext>,IRegionDal
    {
    }
}
