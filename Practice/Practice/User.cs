using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class User
    {
        public int Id { get; set; }
        public int Age { get; set; } 

        public static bool operator > (User user1 , User user2)
        {
            return user1.Age > user2.Age;
        }

        public static bool operator < (User user1, User user2)
        {
            return user1.Age < user2.Age;
        }
    }
}
