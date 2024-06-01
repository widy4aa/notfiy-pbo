using notfiy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using notfiy.Entities;
using notfiy.Helpers;
using notfiy.Core;

namespace notfiy.Controllers
{
    class UserController
    {
        private UserModel UserModel;
        public UserController()
        {
            UserModel = new UserModel();
        }
        public bool AuthAttempt(string username, string password)
        {
            User? user = UserModel.UserAuth(username, password);
            if (user == null){
                return false;
            }
            SystemSingleton.Instance.UserLoggedIn = user;
            return true;
        }

        public bool UpdateUser(int idUser, string username, string password, string email)
        {
            User user = UserModel.GetUserById(idUser);

            user.Username = username;
            user.Password = password;
            user.Email = email;
            
            return UserModel.UpdateUser(user);
        }

        public bool CreateUser(string username, string password, string email)
        {
            User user = new User()
            {
                Username = username,
                Password = password,
                Email = email,
                TimeCreated = DateTime.Now
            };
            return (UserModel.CreateUser(user) > 0);
        }
    }
}
