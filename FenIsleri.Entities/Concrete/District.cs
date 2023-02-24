using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FenIsleri.Entities.Abstract;

namespace FenIsleri.Entities.Concrete
{
    public class District : IEntity
    {
        public byte DistrictId { get; set; }
        public string DistrictName { get; set; }
        public byte Region { get; set; }
    }
}
