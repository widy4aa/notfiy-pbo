using System;
using Npgsql;
using notfiy.Entities;
using notfiy.Core;

namespace notfiy.Models
{
    internal class NoteModel
    {
        private string connection;
        private NpgsqlConnection conn;

        //private Model conn;

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
        {
            string read = @"SELECT row_number(*) over() as nomor, id_notes,  FROM notes;";


            using (NpgsqlConnection conn = new NpgsqlConnection(connection))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(read, conn))
                {
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    ListNote.Clear();
                    while (reader.Read())
                    {
                        Note note = new Note();
                        note.id_note = (int)reader["id_note"];
                        note. = (string)reader[""];
                        note. = (string)reader[""];
                        note. = (string)reader[""];
                        ListNote.Add(note);
                    }
                }
            }
        }

        public bool CreateNote(Note note)
        {
            try
            {
                conn.Open();
                string insert = @"INSERT INTO notes (id_note, ) 
                    VALUES (default, )";
                using (NpgsqlCommand cmd = new NpgsqlCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@", note.note_);
                    cmd.Parameters.AddWithValue("@", note.);
                    cmd.Parameters.AddWithValue("@", note.);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert fail! Error: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool UpdateNote()
        {

        }

        public bool DeleteNote()
        {

        }
    }
}