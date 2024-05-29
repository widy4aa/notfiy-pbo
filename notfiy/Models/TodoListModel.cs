using System;
using System.Collections.Generic;
using notfiy.Core;
using notfiy.Entities;
using Npgsql;

namespace notfiy.Models
{
    class TodoListModel : Model
    {
        public List<TodoList> GetAllTodoList()
        {
            List<TodoList> todoLists = new List<TodoList>();
              
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("select * from todolists", Connection);
            NpgsqlDataReader reader = npgsqlCommand.ExecuteReader();
            while (reader.Read())
            {
                TodoList todoList = new TodoList
                {
                    IdTodoList = reader.GetInt32(reader.GetOrdinal("id_todolist")),
                    TodoListName = reader.GetString(reader.GetOrdinal("todolist_name")),
                    TimeCreated = reader.GetString(reader.GetOrdinal("time_created")),
                    IdUser = reader.GetInt32(reader.GetOrdinal("id_user")),
                    IdStatus = reader.GetInt32(reader.GetOrdinal("id_status")),
                    Pinned = reader.GetInt32(reader.GetOrdinal("pinned"))
                };

                todoLists.Add(todoList);
            }

            return todoLists;
        }

        public int CreateTodoList(TodoList todoList)
        {
            try
            {
                Connection.Open();
                string insert = @"INSERT INTO todolists (todolist_name, time_created, id_user, id_status, pinned) VALUES 
                (@todolist_name, @time_created, @id_user, @id_status, @pinned) RETURNING id_todolist";
                using (NpgsqlCommand cmd = new NpgsqlCommand(insert, Connection))
                {
                    cmd.Parameters.AddWithValue("todolist_name", todoList.TodoListName);
                    cmd.Parameters.AddWithValue("time_created", todoList.TimeCreated);
                    cmd.Parameters.AddWithValue("id_user", todoList.IdUser);
                    cmd.Parameters.AddWithValue("id_status", todoList.IdStatus);
                    cmd.Parameters.AddWithValue("pinned", todoList.Pinned);
                    object ?result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert failed! Error: " + ex.Message);
                return 0;
            }
            finally
            {
                Connection.Close();
            }
        }


        public bool DeleteTodoList(int idTodoList)
        {
            try
            {
                Connection.Open();
                string delete = @"DELETE FROM todolists WHERE id_todolist = @id_todolist";
                using (NpgsqlCommand cmd = new NpgsqlCommand(delete, Connection))
                {
                    cmd.Parameters.AddWithValue("id_todolist", idTodoList);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed! Error: " + ex.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }

        public bool UpdateTodoList(TodoList todoList)
        {
            try
            {
                Connection.Open();
                string update = @"UPDATE todolists SET 
                                  todolist_name = @todolist_name, 
                                  time_created = @time_created, 
                                  id_user = @id_user, 
                                  id_status = @id_status, 
                                  pinned = @pinned 
                                  WHERE id_todolist = @id_todolist";
                using (NpgsqlCommand cmd = new NpgsqlCommand(update, Connection))
                {
                    cmd.Parameters.AddWithValue("todolist_name", todoList.TodoListName);
                    cmd.Parameters.AddWithValue("time_created", todoList.TimeCreated);
                    cmd.Parameters.AddWithValue("id_user", todoList.IdUser);
                    cmd.Parameters.AddWithValue("id_status", todoList.IdStatus);
                    cmd.Parameters.AddWithValue("pinned", todoList.Pinned);
                    cmd.Parameters.AddWithValue("id_todolist", todoList.IdTodoList);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed! Error: " + ex.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }

        public TodoList ?GetTodoList(int idTodoList)
        {
            try
            {
                Connection.Open();
                string query = @"SELECT * FROM todolists WHERE id_todolist = @id_todolist";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, Connection))
                {
                    cmd.Parameters.AddWithValue("id_todolist", idTodoList);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new TodoList
                            {
                                IdTodoList = reader.GetInt32(reader.GetOrdinal("id_todolist")),
                                TodoListName = reader.GetString(reader.GetOrdinal("todolist_name")),
                                TimeCreated = reader.GetString(reader.GetOrdinal("time_created")),
                                IdUser = reader.GetInt32(reader.GetOrdinal("id_user")),
                                IdStatus = reader.GetInt32(reader.GetOrdinal("id_status")),
                                Pinned = reader.GetInt32(reader.GetOrdinal("pinned"))
                            };
                        }
                        else
                        {
                            return null; // Return null if no record is found
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Retrieval failed! Error: " + ex.Message);
                return null;
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
