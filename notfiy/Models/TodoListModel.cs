using System;
using System.Collections.Generic;
using notfiy.Core;
using notfiy.Entities;
using notfiy.Helpers;
using Npgsql;

namespace notfiy.Models
{
    class TodoListModel : Model
    {
        public List<TodoList> GetAllTodoList(int idUser, int idStatus)
        {
            List<TodoList> todoLists = new List<TodoList>();
              
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand($"select * from todolists where id_user = {idUser} and id_status = {idStatus}", Connection);
            NpgsqlDataReader reader = npgsqlCommand.ExecuteReader();
            while (reader.Read())
            {
                TodoList todoList = new TodoList
                {
                    IdTodoList = (int) reader["id_todo]ist"],
                    TodoListName = (string)reader["todolist_name"],
                    TimeCreated = (DateTime)reader["time_created"],
                    IdUser = (int) reader["id_user"],
                    IdStatus = (int) reader["id_status"],
                    Pinned = (bool) reader["pinned"]
                };

                todoLists.Add(todoList);
            }

            return todoLists;
        }

        public int GetIdNewTodoList(int Iduser)
        {
            Connection.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("select max(id_user) from todolists WHERE id_user = @idUser", Connection);
            npgsqlCommand.Parameters.AddWithValue("@idUser", Iduser);
            object ?result = npgsqlCommand.ExecuteScalar();
            Connection.Close();
            return result != null ? Convert.ToInt32(result) : 1;
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
                MessageBoxHelper.ShowErrorMessageBox("Insert failed! Error: " + ex.Message);
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
                MessageBoxHelper.ShowErrorMessageBox("Delete failed! Error: " + ex.Message);
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
                MessageBoxHelper.ShowErrorMessageBox("Update failed! Error: " + ex.Message);
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
                                IdTodoList = (int)reader["id_todolist"],
                                TodoListName = (string)reader["todolist_name"],
                                TimeCreated = (DateTime)reader["time_created"],
                                IdUser = (int)reader["id_user"],
                                IdStatus = (int)reader["id_status"],
                                Pinned = (bool)reader["pinned"]
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
                MessageBoxHelper.ShowErrorMessageBox("Retrieval failed! Error: " + ex.Message);
                return null;
            }
            finally
            {
                Connection.Close();
            }
        }

        public bool UpdateTodoListPin(int idTodoList, bool pinned)
        {
            try
            {
                Connection.Open();
                string update = @"UPDATE todolists SET pinned = @pinned WHERE id_todolist = @id_todolist";
                using (NpgsqlCommand cmd = new NpgsqlCommand(update, Connection))
                {
                    cmd.Parameters.AddWithValue("@id_todolist", idTodoList);
                    cmd.Parameters.AddWithValue("@pinned", pinned);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowErrorMessageBox("Update Label failed! Error: " + ex.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
