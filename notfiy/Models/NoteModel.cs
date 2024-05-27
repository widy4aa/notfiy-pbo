using System;
using Npgsql;

namespace notfiy.Models
{
    internal class NoteModel
    {
        private string connection;
        private NpgsqlConnection conn;

        public List<Note> ListModel = new List<Note>();
        public NoteModel(string server, int port, string userId, string password, string database)
        {
            connection = $"Server={server};Port={port};User Id={userId};Password={password};Database={database};";
            conn = new NpgsqlConnection(connection);
        }

        public NpgsqlConnection GetConnection()
        {
            return conn;
        }

        public void ReadNote()

        public bool CreateNote()

        public bool UpdateNote()

        public bool DeleteNote()
    }
}