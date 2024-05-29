using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notfiy.Entities
{
    internal class User
    {
        public int IdUser;
        public required string Username;
        public required string Password;
        public required string Email;
        public required string TimeCreated;
    }
}
