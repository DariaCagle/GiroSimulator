using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiroSimulator
{
    class Comment
    {
        public Comment(string taskID, string authorID, string commentText)
        {
            Id = Guid.NewGuid().ToString();
            TaskID = taskID;
            AuthorID = authorID;
            CommentText = commentText;
            _createdDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
        }

        public string Id { get; set; }

        public readonly string TaskID;

        public readonly string AuthorID;

        public string CommentText;

        private readonly DateTime _createdDate;

        public DateTime UpdatedDate { get; set; }
    }
}
