using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GiroSimulator.Enums;
using GiroSimulator.Interfaces;

namespace GiroSimulator
{
    public class Board
    {
        //public IReporter ReportManager{ get; set; }

        private static Board instance;

        private static List<Task> _tasks;

        public static List<Task> Tasks 
        { get 
            {
            return _tasks;
            } }

        private Board()
        {
            var faker = new Faker();
            var taskBogus = new Faker<Task>()
                    .RuleFor(r => r.Description, f => f.Lorem.Paragraph())
                    .RuleFor(r => r.Estimation, f => f.Random.Double(0, 7))
                    .RuleFor(r => r.Id, Guid.NewGuid().ToString())
                    .RuleFor(r => r.TaskOwner, f => new User(f.Person.UserName, f.Person.LastName, f.Person.Avatar))
                    .RuleFor(r => r.status, f => (Status)f.Random.Int(1, 6))
                    .RuleFor(r => r.Title, f => f.Lorem.Word())
                    .RuleFor(r => r.Type, f => (TaskTypes)f.Random.Int(1, 5));



            var tasks = taskBogus.Generate(faker.Random.Number(120, 200));
            _tasks = tasks;
            foreach (var task in tasks)
            {
                
            }
        }

        public static Board GetInstance()
        {
            if(instance == null)
            {
                instance = new Board();
            }
            return instance;
        }

    }
}
