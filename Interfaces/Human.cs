using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    abstract class Human
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public override string ToString() {
            return $"\nLastName : {LastName}, Name: {FirstName}, birth date = {BirthDate}";
        }
    }
}
