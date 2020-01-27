using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Worker : Employee, IWorker
    {
        public bool isTaskCompleted { get; set; }
        string Task { get; set; }
        public string GetCurrentTask()
        {
            return Task;
        }
    }
}
