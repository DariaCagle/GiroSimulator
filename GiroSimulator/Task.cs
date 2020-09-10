using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GiroSimulator.Enums;

namespace GiroSimulator
{
    public class Task : BaseTask
    {
        public Task()
        {

        }
        public Task(double estimation, TaskTypes type, string title, string description, User creator, Status status = Status.BackLog) : base(estimation, type, title, description, creator, status)
        {

        }
        public override void GetInfo()
        {
            Console.WriteLine("Task");
        }
    }
}
