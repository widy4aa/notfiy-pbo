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
                string query = "SELECT * FROM do_items WHERE id_todolist = @id_todolist";
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
                                DoItemName = reader.GetString(reader.GetOrdinal("do_item_name")),
                                Checked = reader.GetBoolean(reader.GetOrdinal("checked")),
                                IdTodoList = reader.GetInt32(reader.GetOrdinal("id_todolist"))
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
                string insert = @"INSERT INTO do_items (do_item_name, checked, id_todolist) VALUES 
                                  (@do_item_name, @checked, @id_todolist) RETURNING id_do_item";
                using (NpgsqlCommand cmd = new NpgsqlCommand(insert, Connection))
                {
                    cmd.Parameters.AddWithValue("do_item_name", doItem.DoItemName);
                    cmd.Parameters.AddWithValue("checked", doItem.Checked);
                    cmd.Parameters.AddWithValue("id_todolist", doItem.IdTodoList);

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

        //public bool InsertDoItem(DoItem doItem)
        //{
        //    try
        //    {
        //        Connection.Open();
        //        string insertQuery = @"INSERT INTO do_items (do_item_name, checked, id_todolist) 
        //                               VALUES (@DItemName, @Checked, @IdTodoList)";
        //        using (NpgsqlCommand cmd = new NpgsqlCommand(insertQuery, Connection))
        //        {
        //            cmd.Parameters.AddWithValue("DOItemName", doItem.DoItemName);
        //            cmd.Parameters.AddWithValue("Checked", doItem.Checked);
        //            cmd.Parameters.AddWithValue("IdTodoList", doItem.IdTodoList);

        //            int rowsAffected = cmd.ExecuteNonQuery();

        //            return rowsAffected > 0;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Insert failed! Error: " + ex.Message);
        //        return false;
        //    }
        //    finally
        //    {

        //        Connection.Close();
        //    }
        //}

            public bool DeleteDoItem(int idDoItem)
        {
            try
            {
                Connection.Open();
                string delete = @"DELETE FROM do_items WHERE id_do_item = @id_do_item";
                using (NpgsqlCommand cmd = new NpgsqlCommand(delete, Connection))
                {
                    cmd.Parameters.AddWithValue("id_do_item", idDoItem);
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
                                  do_item_name = @do_item_name, 
                                  checked = @checked, 
                                  id_todolist = @id_todolist, 
                                  WHERE id_do_item = @id_do_item";
                using (NpgsqlCommand cmd = new NpgsqlCommand(update, Connection))
                {
                    cmd.Parameters.AddWithValue("id_do_item", doItem.IdDoItem);
                    cmd.Parameters.AddWithValue("do_item_name", doItem.DoItemName);
                    cmd.Parameters.AddWithValue("checked", doItem.Checked);
                    cmd.Parameters.AddWithValue("id_todolist", doItem.IdTodoList);

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

        public bool DoItemCheck(int idDoItem, bool Checked)
        {
            try
            {
                Connection.Open();
                string update = @"UPDATE doitems SET checked = @checked WHERE id_do_item = @id_do_item";
                using (NpgsqlCommand cmd = new NpgsqlCommand(update, Connection))
                {
                    cmd.Parameters.AddWithValue("checked", Checked);
                    cmd.Parameters.AddWithValue("id_do_item", idDoItem);

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
                string query = @"SELECT * FROM do_items WHERE id_do_item = @id_do_item";
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
                                DoItemName = reader.GetString(reader.GetOrdinal("do_item_name")),
                                Checked = reader.GetBoolean(reader.GetOrdinal("checked")),
                                IdTodoList = reader.GetInt32(reader.GetOrdinal("id_todolist"))
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
