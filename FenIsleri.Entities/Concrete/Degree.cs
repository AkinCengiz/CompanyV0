using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FenIsleri.Entities.Abstract;

namespace FenIsleri.Entities.Concrete
{
    public class Degree : IEntity
    {
        public int DegreeId { get; set; }
        public string DegreeName { get; set; }
    }
}
