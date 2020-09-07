using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiroSimulator
{
    public class User
    {
        public User(string firstName, string lastName, string image)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = Guid.NewGuid().ToString();
            Image = image;
            _createdDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Id { get; set; }

        public string Image { get; set; }

        private readonly DateTime _createdDate;

        public DateTime UpdatedDate { get; set; }
    }
}
