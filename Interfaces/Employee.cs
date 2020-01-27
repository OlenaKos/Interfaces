using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    abstract class Employee : Human, IEmployee
    {
        public string Position{ set; get; }
        public Double Experience { set; get; }
        public Double GetExperience()
        {
            return Experience;
        }


    }
}
