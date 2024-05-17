using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notfiy.Core
{
    internal class SystemSingleton
    {
        private static SystemSingleton _instance;
        
        public NpgsqlConnection NpgsqlConnection;

        public ViewManager ViewManager;
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
            try {
                NpgsqlConnection = new NpgsqlConnection(connectionString);
                NpgsqlConnection.Open();
            } catch (Exception ex)
            {
                throw new Exception("Tidak dapat terhubung ke database!");
            }

            NpgsqlConnection.Close();

        }

    }
}
