using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notfiy.Helpers
{
    internal class ReaderHelper
    {
        public static string GetValuesToString(NpgsqlDataReader reader)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{ ");
            for (int i = 0; i < reader.FieldCount; i++)
            {
                string columnName = reader.GetName(i);
                string columnValue = reader.IsDBNull(i) ? "" : reader.GetString(i);
                sb.Append($"{columnName} : \"{columnValue}\"");

                if (i < reader.FieldCount - 1)
                {
                    sb.Append(", ");
                }
            }
            sb.Append(" }");
            return sb.ToString();
        }
    }
}
