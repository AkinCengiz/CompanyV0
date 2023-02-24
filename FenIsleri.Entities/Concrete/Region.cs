using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FenIsleri.Entities.Abstract;

namespace FenIsleri.Entities.Concrete
{
    public class Region : IEntity
    {
        public byte RegionId { get; set; }
        public string RegionName { get; set; }
    }
}
