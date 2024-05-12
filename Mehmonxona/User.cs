using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string PassportId { get; set; }

        public User(string name, int age, string passportId)
        {
            Name = name;
            Age = age;
            PassportId = passportId;
        }
    }
}
