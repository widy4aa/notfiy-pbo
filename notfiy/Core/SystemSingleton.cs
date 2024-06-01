using notfiy.Entities;
using notfiy.Helpers;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormLabel = System.Windows.Forms.Label;

namespace notfiy.Core
{
    internal class SystemSingleton
    {
        private static SystemSingleton _instance;
        public NpgsqlConnection NpgsqlConnection;
        public ViewManager ViewManager;
        public User UserLoggedIn;
        private SystemSingleton() 
        {
            ViewManager = new ViewManager();
        }

        public static SystemSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SystemSingleton();
                }

                return _instance;
            }
        }

        public void EnableDatabase(string connectionString)
        {

            var connectionForm = new Form
            {
                Text = "Berusaha Menyambung ke Database!",
                Size = new System.Drawing.Size(500, 1),
                StartPosition = FormStartPosition.CenterScreen,
            };

            connectionForm.Show();


            try
            {
                NpgsqlConnection = new NpgsqlConnection(connectionString);
                NpgsqlConnection.Open();
                connectionForm.Text = "Menyambung ke database sukses!";

            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowErrorMessageBox(ex.Message);
            }
            finally
            {
                connectionForm.Close();
                NpgsqlConnection.Close();
            }
        }

    }
}
