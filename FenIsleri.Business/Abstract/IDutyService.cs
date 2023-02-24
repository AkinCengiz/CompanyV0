using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FenIsleri.DataAccess.Abstract;
using FenIsleri.DataAccess.Concrete.EntityFramework;
using FenIsleri.Entities.Concrete;

namespace FenIsleri.Business.Abstract
{
    public interface IDutyService : IServiceRepository<EfDutyDal, Duty>
    {
    }
}
