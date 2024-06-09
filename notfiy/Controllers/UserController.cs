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

        public List<User> GetAllUsers()
        {
            return UserModel.GetAllUsers();
        }

        public User? GetUserById(int idUser)
        {
            return UserModel.GetUserById(idUser);
        }

        public int GetUserLoggedIn()
        {
            return SystemSingleton.Instance.UserLoggedIn?.IdUser ?? 0;
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

        public bool IsUserTaken(string username, string email, int idUser)
        {
            var users = UserModel.GetAllUsers();
            return users.Any(user => (user.Username == username || user.Email == email) && user.IdUser != idUser);
        }

        public bool UpdateUser(int idUser, string username, string password, string email)
        {
            User user = UserModel.GetUserById(idUser);

            user.Username = username;
            user.Password = password;
            user.Email = email;
            
            return UserModel.UpdateUser(user);
        }

        public bool DeleteUser(int idUser)
        {
            try
            {
                // Hapus akun pengguna dari database
                return UserModel.DeleteUser(idUser);
            }
            catch (Exception ex)
            {
                // Handle exception (log it, rethrow it, etc.)
                MessageBoxHelper.ShowErrorMessageBox(ex.Message);
                return false;
            }
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
