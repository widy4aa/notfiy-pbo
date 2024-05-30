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
        UserController()
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

        public bool UpdateUser(int idUser, string username, string password, string email, string timeCreated)
        {
            User user = new User()
            {
                IdUser = idUser,
                Username = username,
                Password = password,
                Email = email,
                TimeCreated = timeCreated
            };
            return UserModel.UpdateUser(user);
        }

        public bool CreateUser(string username, string password, string email)
        {
            User user = new User()
            {
                Username = username,
                Password = password,
                Email = email,
                TimeCreated = Time.CurrentTimeStamp()
            };
            return (UserModel.CreateUser(user) > 0);
        }
    }
}
