using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FenIsleri.Entities.Abstract;

namespace FenIsleri.Entities.Concrete
{
    public class StaffStatu : IEntity
    {
        public byte StaffStatuId { get; set; }
        public string StaffName { get; set; }
    }
}
