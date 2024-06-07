using notfiy.Entities;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using notfiy.Core;
using notfiy.Helpers;
using Newtonsoft.Json;

namespace notfiy.Models
{
    internal class UserModel : Model
    {

        public List<User> GetAllUsers()
        {
            var users = new List<User>();
            var command = new NpgsqlCommand("SELECT * FROM users", Connection);

            try
            {
                Connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        User user = new User()
                        {
                            IdUser = (int)reader["id_user"],
                            Username = (string)reader["username"],
                            Password = (string)reader["password"],
                            Email = (string)reader["email"],
                            TimeCreated = (DateTime)reader["time_created"]
                        };
                        users.Add(user);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception (log it, rethrow it, etc.)
                MessageBoxHelper.ShowErrorMessageBox(ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return users;
        }

        public User? GetUserById(int id)
        {
            User? user = null;
            var command = new NpgsqlCommand("SELECT * FROM users WHERE id_user = @id", Connection);

            try
            {
                Connection.Open();
                command.Parameters.AddWithValue("@id", id);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new User
                        {
                            IdUser = (int)reader["id_user"],
                            Username = (string)reader["username"],
                            Password = (string)reader["password"],
                            Email = (string)reader["email"],
                            TimeCreated = (DateTime)reader["time_created"]
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception (log it, rethrow it, etc.)
                MessageBoxHelper.ShowErrorMessageBox(ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return user;
        }

        public int CreateUser(User user)
        {
            try
            {
                Connection.Open();
                string QueryInsert = @"INSERT INTO users(username,password,email,time_created) VALUES (@username,@password,@email,@time_created)
                                        RETURNING id_user";
                using(NpgsqlCommand command = new NpgsqlCommand(QueryInsert, Connection))
                {
                    command.Parameters.AddWithValue("username", user.Username);
                    command.Parameters.AddWithValue("password", user.Password);
                    command.Parameters.AddWithValue("email", user.Email);
                    command.Parameters.AddWithValue("time_created", user.TimeCreated);
                    object ?result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowErrorMessageBox(ex.Message);
                return 0;
            }
            finally
            {
                Connection.Close();
            }
        }


        public bool DeleteUser(int IdUser)
        {
            try
            {
                Connection.Open();
                string QueryDel = @"DELETE FROM users WHERE id_user = @IdUser";
                using(NpgsqlCommand command = new NpgsqlCommand(QueryDel, Connection))
                {
                    command.Parameters.AddWithValue("id_user", IdUser);
                    int row = command.ExecuteNonQuery();
                    return row > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowErrorMessageBox(ex.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }

        public bool UpdateUser(User user)
        {
            MessageBoxHelper.ShowInfoMessageBox(JsonConvert.SerializeObject(user));
            try
            {
                Connection.Open();
                string QueryUpdate = @"UPDATE users SET
                                 username = @Username,
                                 password = @Password,
                                 email = @Email,
                                 time_created = @TimeCreated
                                 WHERE id_user = @IdUser";
                using (NpgsqlCommand command = new NpgsqlCommand(QueryUpdate, Connection))
                {
                    command.Parameters.AddWithValue("IdUser", user.IdUser);
                    command.Parameters.AddWithValue("Username", user.Username);
                    command.Parameters.AddWithValue("Password", user.Password);
                    command.Parameters.AddWithValue("Email", user.Email);
                    command.Parameters.AddWithValue("TimeCreated", user.TimeCreated);
                    int row = command.ExecuteNonQuery();
                    return row > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowErrorMessageBox(ex.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }
        public bool IsUsernameTaken(string username)
        {
            var command = new NpgsqlCommand("SELECT COUNT(*) FROM users WHERE username = @username", Connection);
            command.Parameters.AddWithValue("@username", username);
            Connection.Open();
            //var result = command.ExecuteNonQuery();
            var result = (long)command.ExecuteScalar();
            Connection.Close();
            return result > 0;
        }

        public bool IsEmailTaken(string email)
        {
            var command = new NpgsqlCommand("SELECT COUNT(*) FROM users WHERE email = @email", Connection);
            command.Parameters.AddWithValue("@email", email);
            Connection.Open();
            //var result = command.ExecuteNonQuery();
            var result = (long)command.ExecuteScalar();
            Connection.Close();
            return result > 0;
        }   

        public User? UserAuth(string username, string password)
        {
            User? user = null;
            var command = new NpgsqlCommand("SELECT * FROM users WHERE username = @username AND password = @password", Connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            try
            {
                Connection.Open();

                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    user = new User
                    {
                        IdUser = (int)reader["id_user"],
                        Username = (string)reader["username"],
                        Password = (string)reader["password"],
                        Email = (string)reader["email"],
                        TimeCreated = (DateTime)reader["time_created"]
                    };

                }
                
            }
                catch (Exception ex)
            {
                // Handle exception (log it, rethrow it, etc.)
                MessageBoxHelper.ShowErrorMessageBox(ex.Message);
               }
            finally
            {
                Connection.Close();
            }
            return user;
        }

    }
}
