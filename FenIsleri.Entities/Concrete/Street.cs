using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FenIsleri.Entities.Abstract;

namespace FenIsleri.Entities.Concrete
{
    public class Street : IEntity
    {
        public int StreetId { get; set; }
        public string StreetName { get; set; }
        public byte District { get; set; }
    }
}
