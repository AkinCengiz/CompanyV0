using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FenIsleri.Entities.Abstract;

namespace FenIsleri.Entities.Concrete
{
    public class Duty : IEntity
    {
        public byte DutyId { get; set; }
        public string DutyName { get; set; }
    }
}
