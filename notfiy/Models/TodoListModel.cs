using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using notfiy.Core;
using notfiy.Entities;
using Npgsql;

namespace notfiy.Models
{
    class TodoListModel : Model
    {
        public List<TodoList> GetAll()
        {
            List<TodoList> todoLists = new List<TodoList>();
              
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand();
            NpgsqlDataReader reader = npgsqlCommand.ExecuteReader();
            while (reader.Read())
            {
                TodoList todoList = new TodoList
                {
                    IdTodoList = reader.GetInt32(reader.GetOrdinal("id_todolist")),
                    TodoListName = reader.GetString(reader.GetOrdinal("todolist_name")),
                    Timestamp = reader.GetString(reader.GetOrdinal("timestamp"))
                };

                todoLists.Add(todoList);
            }


            return todoLists;
        }
    }
}
