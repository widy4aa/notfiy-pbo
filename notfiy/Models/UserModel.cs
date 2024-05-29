using notfiy.Entities;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using notfiy.Core;

namespace notfiy.Models
{
    internal class UserModel : Model
    {

        public List<User> GetAllUsers()
        {
            var users = new List<User>();
            var command = new NpgsqlCommand("SELECT * FROM users", Connection);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    User user = new User(){
                        IdUser = (int)reader["id_users"],
                        Username = (string)reader["username"],
                        Password = (string)reader["password"],
                        Email = (string)reader["email"],
                        TimeCreated = (string)reader["time_created"]
                    };
                    users.Add(user);
                }
            }
            return users;
        }

        public User ?GetUsersById(int id)
        {
            User ?user = null;
            var command = new NpgsqlCommand("SELECT * FROM users WHERE id_user = @id", Connection);
            using (command)
            {
                command.Parameters.AddWithValue("@id",id);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new User
                        {
                            IdUser = (int)reader["id_users"],
                            Username = (string)reader["username"],
                            Password = (string)reader["password"],
                            Email = (string)reader["email"],
                            TimeCreated = (string)reader["time_created"]
                        };
                    }
                }
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
                MessageBox.Show("Gagal Membuat User! Error: " + ex.Message);
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
                MessageBox.Show("Gagal Menghapus User! Error: " + ex.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }

        public bool UpdateUser(User user)
        {
            try
            {
                Connection.Open();
                string QueryUpdate = @"UPDATE users SET
                                 id_users = @IdUser
                                 username = @Username
                                 password = @Password
                                 email = @Email
                                 time_created = @TimeCreated";
                using (NpgsqlCommand command = new NpgsqlCommand(QueryUpdate, Connection))
                {
                    command.Parameters.AddWithValue("id_users", user.IdUser);
                    command.Parameters.AddWithValue("username", user.Username);
                    command.Parameters.AddWithValue("password", user.Password);
                    command.Parameters.AddWithValue("email", user.Email);
                    command.Parameters.AddWithValue("time_created", user.TimeCreated);
                    int row = command.ExecuteNonQuery();
                    return row > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Update User! Error: " + ex.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }

    }
}
