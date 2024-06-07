using notfiy.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notfiy.Entities
{
    public class User : Entity
    {
        public int IdUser;
        public required string Username;
        public required string Password;
        public required string Email;
        public required DateTime TimeCreated;
    }
}
