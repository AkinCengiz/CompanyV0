using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FenIsleri.Entities.Abstract;

namespace FenIsleri.Entities.Concrete
{
    public class Employee : IEntity
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime WorkDate { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int City { get; set; }
        public int Town { get; set; }
        public string IdentityNumber { get; set; }
        public int Degree { get; set; }
        public byte Duty { get; set; }
        public byte StaffStatus { get; set; }
        public byte Chiefdom { get; set; }
    }
}
