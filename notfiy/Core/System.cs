using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notfiy.Core
{
    internal class System
    {
        private static System _instance;
        
        public NpgsqlConnection NpgsqlConnection;

        public ViewManager ViewManager;
        private System() 
        { 
            SetAtributes();
        }

        public static System Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new System();
                }

                return _instance;
            }
        }

        public void EnableDatabase(string connectionString)
        {
            try {
                NpgsqlConnection = new NpgsqlConnection(connectionString);                 
            } catch (Exception ex)
            {
                throw new Exception("Tidak dapat terhubung ke database!");
            }
        }

        private void SetAtributes()
        {
            ViewManager = new ViewManager();
        }

    }
}
