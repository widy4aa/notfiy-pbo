using notfiy.Entities;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notfiy.Models
{
    internal class UserModel
    {
        private string connectionString;
        public UserModel()
        {
            connectionString = "";
        }

        public List<User> GetAllUsers()
        {
            var users = new List<User>();

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var command = new NpgsqlCommand("SELECT id, name, email, password FROM users", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new User
                        {
                            //Id = reader.GetInt32(0),
                            //Name = reader.GetString(1),
                            //Email = reader.GetString(2),
                            //Password = reader.GetString(3)
                        });
                    }
                }
            }

            return users;
        }


    }
}
