using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GiroSimulator.Enums;

namespace GiroSimulator
{
    public abstract class BaseTask
    {
        public BaseTask()
        {

        }
        public BaseTask(double estimation, TaskTypes type, string title, string description, User creator, Status status = Status.BackLog)
        {
            Estimation = estimation;
            Type = type;
            Title = title;
            Description = description;
            Id = Guid.NewGuid().ToString();
            _createdDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
            taskCreator = creator;
            this.status = status;
        }

        public double Estimation { get; set; }

        public TaskTypes Type { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Id { get; set; }

        private readonly DateTime _createdDate;

        public DateTime UpdatedDate { get; set; }

        public readonly User taskCreator;
        public User TaskOwner { get; set; }

        public Status status;

        public abstract void GetInfo();
    }
}
