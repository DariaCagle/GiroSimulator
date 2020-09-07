using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiroSimulator
{
    class Attachment
    {
        public Attachment(string name, string link, string userID, string taskID)
        {
            Link = link;
            Name = name;
            createdDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
            Id = Guid.NewGuid().ToString();
            UserID = userID;
            TaskID = taskID;
        }

        public string Link { get; set; }

        public string Name { get; set; }

        private readonly DateTime createdDate;
        public DateTime UpdatedDate { get; set; }

        public string Id { get; set; }

        public readonly string UserID;

        public readonly string TaskID;

    }
}
