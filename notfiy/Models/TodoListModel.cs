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
        public List<TodoLists> GetAllTodoList()
        {
            List<TodoLists> todoLists = new List<TodoLists>();
              
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("select * from todolists", Connection);
            NpgsqlDataReader reader = npgsqlCommand.ExecuteReader();
            while (reader.Read())
            {
                TodoLists todoList = new TodoLists
                {
                    IdTodoList = reader.GetInt32(reader.GetOrdinal("id_todolist")),
                    TodoListName = reader.GetString(reader.GetOrdinal("todolist_name")),
                    TimeCreated = reader.GetString(reader.GetOrdinal("time_created")),
                    IdUser = reader.GetInt32(reader.GetOrdinal("id_user")),
                    IdTodoListStatus = reader.GetInt32(reader.GetOrdinal("id_todolist_status")),
                    IdPinnedItem = reader.GetInt32(reader.GetOrdinal("id_pinned_item"))
                };

                todoLists.Add(todoList);
            }


            return todoLists;
        }
    }
}
