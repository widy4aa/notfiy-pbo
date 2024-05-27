using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notfiy.Core
{
    abstract class Model
    {
        protected NpgsqlConnection Connection;

        public Model() 
        {
            Connection = SystemSingleton.Instance.NpgsqlConnection;
        }

    }
}
