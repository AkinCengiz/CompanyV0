using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FenIsleri.Entities.Abstract;

namespace FenIsleri.Entities.Concrete
{
    public class Chiefdom : IEntity
    {
        public byte ChiefdomId { get; set; }
        public string ChiefdomName { get; set; }
    }
}
