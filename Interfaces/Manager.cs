using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Manager : Employee, IManager
    {
        public bool CheckResult()
        {
            return true;
        }

        public bool GiveTask()
        {
            return true;
        }
    }
}
