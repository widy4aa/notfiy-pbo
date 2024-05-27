using notfiy.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace notfiy.Entities
{
    internal class TodoList : IEntity
    {
        public int IdTodoList;
        public string TodoListName;
        public string Timestamp;
    }
}
