using System;
using Npgsql;
using notfiy.Entities;
using notfiy.Core;

namespace notfiy.Models
{
    internal class NoteModel : Model
    {
        public List<Note> GetAllNote()
        {
            List<Note> ListNotes = new List<Note>();

            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("SELECT * FROM notes", Connection);
            NpgsqlDataReader reader = npgsqlCommand.ExecuteReader();
            //ListNotes.Clear();
            while (reader.Read())
            {
                Note notes = new Note
                {
                    IdNote = (int)reader["id_note"],
                    NoteName = (string)reader["note_name"],
                    Content = (string)reader["content"],
                    ImageFileName = (string)reader["image_filename"],
                    TimeCreated = (string)reader["time_created"],
                    IdUser = (int)reader["id_user"],
                    IdLabel = (int)reader["id_label"],
                    IdPinnedItem = (int)reader["id_pinned_item"],
                    IdNoteStatus = (int)reader["id_note_status"]
                };
                ListNotes.Add(notes);
            }
            return ListNotes;
        }

        public bool CreateNote(Note note)
        {
            try
            {
                Connection.Open();
                string insert = @"INSERT INTO notes (note_name, content, image_filename, time_created, id_user, id_label, id_pinned_item, id_note_status) VALUES (@note_name, @content, @image_filename, @time_created, @id_user, @id_label, @id_pinned_item, @id_note_status)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(insert, Connection))
                {
                    cmd.Parameters.AddWithValue("@id_note", note.IdNote);
                    cmd.Parameters.AddWithValue("@note_name", note.NoteName);
                    cmd.Parameters.AddWithValue("@content", note.Content);
                    cmd.Parameters.AddWithValue("@image_filename", note.ImageFileName);
                    cmd.Parameters.AddWithValue("@time_created", note.TimeCreated);
                    cmd.Parameters.AddWithValue("@id_user", note.IdUser);
                    cmd.Parameters.AddWithValue("@id_label", note.IdLabel);
                    cmd.Parameters.AddWithValue("@id_pinned_item", note.IdPinnedItem);
                    cmd.Parameters.AddWithValue("@id_note_status", note.IdNoteStatus);
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
                Connection.Close();
            }
        }

        public bool UpdateNote(Note note)
        {
            try
            {
                Connection.Open();
                string update = @"UPDATE notes SET note = @note_name, content = @content, image_filename = @image_filename, time_created = @time_created, id_user = @id_user, id_label = @id_label, id_pinned_item = @id_pinned_item, id_note_status = @id_note_status WHERE id_note = @id_note";
                using (NpgsqlCommand cmd = new NpgsqlCommand(update, Connection))
                {
                    cmd.Parameters.AddWithValue("@id_note", note.IdNote);
                    cmd.Parameters.AddWithValue("@note_name", note.NoteName);
                    cmd.Parameters.AddWithValue("@content", note.Content);
                    cmd.Parameters.AddWithValue("@image_filename", note.ImageFileName);
                    cmd.Parameters.AddWithValue("@time_created", note.TimeCreated);
                    cmd.Parameters.AddWithValue("@id_user", note.IdUser);
                    cmd.Parameters.AddWithValue("@id_label", note.IdLabel);
                    cmd.Parameters.AddWithValue("@id_pinned_item", note.IdPinnedItem);
                    cmd.Parameters.AddWithValue("@id_note_status", note.IdNoteStatus);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("update fail! Error: " + ex.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }

        public bool DeleteNote(int idNote)
        {
            
            try
            {
                Connection.Open();
                string insert = @"DELETE FROM notes WHERE id_note = @id_note";
                using (NpgsqlCommand cmd = new NpgsqlCommand(insert, Connection))
                {
                    cmd.Parameters.AddWithValue("@id_note", idNote);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete fail! Error: " + ex.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}