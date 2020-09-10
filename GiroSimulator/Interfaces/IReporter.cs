using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GiroSimulator;

namespace GiroSimulator.Interfaces
{
    public interface IReporter
    {
        List<Task> GetAll();
        List<Task> GetFromEstimateRange(double startEstimation, double finishEstimation);
    }
}
