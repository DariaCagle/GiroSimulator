using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GiroSimulator.Interfaces;

namespace GiroSimulator
{


    public class BaseReportManager : IReporter
    {
        private List<Task> _tasks;
        public BaseReportManager(Board board)
        {
            _tasks = Board.Tasks;
        }

        public List<Task> GetAll()
        {
            return _tasks;
        }

        public List<Task> GetFromEstimateRange(double startEstimation = 0, double finishEstimation = Double.MaxValue)
        {
            return _tasks.Where(task => task.Estimation >= startEstimation && task.Estimation <= finishEstimation).ToList();
        }

    }
}
