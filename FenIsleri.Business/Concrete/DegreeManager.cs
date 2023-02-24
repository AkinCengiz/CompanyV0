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
    public class DegreeManager : ManagerRepositoryBase<Degree,EfDegreeDal>,IDegreeService
    {
        private IDegreeDal _degreeDal;

        public DegreeManager(IDegreeDal degreeDal)
        {
            _degreeDal = degreeDal;
        }
    }
}
