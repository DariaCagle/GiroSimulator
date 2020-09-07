using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiroSimulator.Enums
{
    public enum Status
    {
        BackLog = 1,
        ToDo = 2,
        InProgress = 3,
        ReadyForQA = 4,
        Reopen = 5,
        Done = 6
    }
}
