using GiroSimulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GiroSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var board  = Board.GetInstance();
            IReporter baseReportManager = new BaseReportManager(board);
        }
    }
}
