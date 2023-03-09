using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FenIsleri.Entities.Abstract;

namespace FenIsleri.Entities.Concrete
{
    public class City : IEntity
    {
        public int ID { get; set; }
        public string CityName { get; set; }
    }
}
