using System;
using System.Collections.Generic;
using Npgsql;
using notfiy.Entities;
using notfiy.Core;

namespace notfiy.Models
{
    internal class DoItemModel : Model
    {
        public List<DoItem> GetAllDoItems(int idTodoList)
        {
            List<DoItem> doItems = new List<DoItem>();

            try
            {
                Connection.Open();
                string query = "SELECT * FROM doitems WHERE id_todolist = @id_todolist";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, Connection))
                {
                    cmd.Parameters.AddWithValue("id_todolist", idTodoList);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DoItem doItem = new DoItem
                            {
                                IdDoItem = reader.GetInt32(reader.GetOrdinal("id_doitem")),
                                Description = reader.GetString(reader.GetOrdinal("description")),
                                IsCompleted = reader.GetBoolean(reader.GetOrdinal("is_completed")),
                                IdTodoList = reader.GetInt32(reader.GetOrdinal("id_todolist")),
                                IdStatus = reader.GetInt32(reader.GetOrdinal("id_status")),
                                TimeCreated = reader.GetDateTime(reader.GetOrdinal("time_created"))
                            };

                            doItems.Add(doItem);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Retrieval failed! Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return doItems;
        }

        public int CreateDoItem(DoItem doItem)
        {
            try
            {
                Connection.Open();
                string insert = @"INSERT INTO doitems (description, is_completed, id_todolist, id_status, time_created) VALUES 
                                  (@description, @is_completed, @id_todolist, @id_status, @time_created) RETURNING id_doitem";
                using (NpgsqlCommand cmd = new NpgsqlCommand(insert, Connection))
                {
                    cmd.Parameters.AddWithValue("description", doItem.Description);
                    cmd.Parameters.AddWithValue("is_completed", doItem.IsCompleted);
                    cmd.Parameters.AddWithValue("id_todolist", doItem.IdTodoList);
                    cmd.Parameters.AddWithValue("id_status", doItem.IdStatus);
                    cmd.Parameters.AddWithValue("time_created", doItem.TimeCreated);

                    object? result = cmd.ExecuteScalar();
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

        public bool InsertDoItem(DoItem doItem)
        {
            try
            {
                Connection.Open();
                string insertQuery = @"INSERT INTO doitems (DOItemName, IsCompleted, IdTodoList, IdStatus, TimeCreated) 
                                       VALUES (@DOItemName, @IsCompleted, @IdTodoList, @IdStatus, @TimeCreated)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(insertQuery, Connection))
                {
                    cmd.Parameters.AddWithValue("DOItemName", doItem.DOItemName);
                    cmd.Parameters.AddWithValue("IsCompleted", doItem.IsCompleted);
                    cmd.Parameters.AddWithValue("IdTodoList", doItem.IdTodoList);
                    cmd.Parameters.AddWithValue("IdStatus", doItem.IdStatus);
                    cmd.Parameters.AddWithValue("TimeCreated", doItem.TimeCreated);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Insert failed! Error: " + ex.Message);
                return false;
            }
            finally
            {

                Connection.Close();
            }
        }

            public bool DeleteDoItem(int idDoItem)
        {
            try
            {
                Connection.Open();
                string delete = @"DELETE FROM doitems WHERE id_doitem = @id_doitem";
                using (NpgsqlCommand cmd = new NpgsqlCommand(delete, Connection))
                {
                    cmd.Parameters.AddWithValue("id_doitem", idDoItem);
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

        public bool UpdateDoItem(DoItem doItem)
        {
            try
            {
                Connection.Open();
                string update = @"UPDATE doitems SET 
                                  description = @description, 
                                  is_completed = @is_completed, 
                                  id_todolist = @id_todolist, 
                                  id_status = @id_status, 
                                  time_created = @time_created 
                                  WHERE id_doitem = @id_doitem";
                using (NpgsqlCommand cmd = new NpgsqlCommand(update, Connection))
                {
                    cmd.Parameters.AddWithValue("description", doItem.Description);
                    cmd.Parameters.AddWithValue("is_completed", doItem.IsCompleted);
                    cmd.Parameters.AddWithValue("id_todolist", doItem.IdTodoList);
                    cmd.Parameters.AddWithValue("id_status", doItem.IdStatus);
                    cmd.Parameters.AddWithValue("time_created", doItem.TimeCreated);
                    cmd.Parameters.AddWithValue("id_doitem", doItem.IdDoItem);

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

        public bool UpdateStatusDoItem(int idDoItem, int idStatus)
        {
            try
            {
                Connection.Open();
                string update = @"UPDATE doitems SET id_status = @id_status WHERE id_doitem = @id_doitem";
                using (NpgsqlCommand cmd = new NpgsqlCommand(update, Connection))
                {
                    cmd.Parameters.AddWithValue("id_status", idStatus);
                    cmd.Parameters.AddWithValue("id_doitem", idDoItem);

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

        public DoItem? GetDoItem(int idDoItem)
        {
            try
            {
                Connection.Open();
                string query = @"SELECT * FROM doitems WHERE id_doitem = @id_doitem";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, Connection))
                {
                    cmd.Parameters.AddWithValue("id_doitem", idDoItem);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new DoItem
                            {
                                IdDoItem = reader.GetInt32(reader.GetOrdinal("id_doitem")),
                                Description = reader.GetString(reader.GetOrdinal("description")),
                                IsCompleted = reader.GetBoolean(reader.GetOrdinal("is_completed")),
                                IdTodoList = reader.GetInt32(reader.GetOrdinal("id_todolist")),
                                IdStatus = reader.GetInt32(reader.GetOrdinal("id_status")),
                                TimeCreated = reader.GetDateTime(reader.GetOrdinal("time_created"))
                            };
                        }
                        else
                        {
                            return null;
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
