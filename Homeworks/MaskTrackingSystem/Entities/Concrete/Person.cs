using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int BirthDate { get; set; }
        public long IdentityNumber { get; set; }
    }
}
