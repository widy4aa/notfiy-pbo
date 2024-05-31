using System;
using System.Collections.Generic;
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
            while (reader.Read())
            {
                Note note = new Note
                {
                    IdNote = (int)reader["id_note"],
                    NoteName = (string)reader["note_name"],
                    Content = (string)reader["content"],
                    ImageUrl = reader["image_url"] as string,
                    TimeCreated = (string)reader["time_created"],
                    Pinned = (bool)reader["pinned"],
                    IdUser = (int)reader["id_user"],
                    IdLabel = (int)reader["id_label"],
                    IdStatus = (int)reader["id_status"]
                };

                ListNotes.Add(note);
            }
            return ListNotes;
        }

        public Note? GetNoteById(int idNote)
        {
            try
            {
                Connection.Open();
                string query = @"SELECT * FROM note WHERE id_note = @id_note";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, Connection))
                {
                    cmd.Parameters.AddWithValue("id_note", idNote);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Note
                            {
                                IdNote = (int)reader["id_note"],
                                NoteName = (string)reader["note_name"],
                                Content = (string)reader["content"],
                                ImageUrl = reader["image_url"] as string,
                                TimeCreated = (string)reader["time_created"],
                                Pinned = (bool)reader["pinned"],
                                IdUser = (int)reader["id_user"],
                                IdLabel = (int)reader["id_label"],
                                IdStatus = (int)reader["id_status"]
                            };
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Retrieval failed! Error: " + ex.Message);
                return null;
            }
            finally
            {
                Connection.Close();
            }
        }

        public int CreateNote(Note note)
        {
            try
            {
                Connection.Open();
                string insert = @"INSERT INTO notes (note_name, content, image_url, time_created, pinned, id_user, id_label, id_status) VALUES (@note_name, @content, @image_url, @time_created, @pinned, @id_user, @id_label, @id_status)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(insert, Connection))
                {
                    cmd.Parameters.AddWithValue("@note_name", note.NoteName);
                    cmd.Parameters.AddWithValue("@content", note.Content);
                    cmd.Parameters.AddWithValue("@image_url", note.ImageUrl ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@time_created", note.TimeCreated);
                    cmd.Parameters.AddWithValue("@pinned", note.Pinned);
                    cmd.Parameters.AddWithValue("@id_user", note.IdUser);
                    cmd.Parameters.AddWithValue("@id_label", note.IdLabel);
                    cmd.Parameters.AddWithValue("@id_status", note.IdStatus);
                    object ?result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert failed! Error: " + ex.Message);
                return 0;
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
                string update = @"UPDATE notes SET 
                                note_name = @note_name, 
                                content = @content, 
                                image_url = @image_url, 
                                time_created = @time_created, 
                                pinned = @pinned,
                                id_user = @id_user, 
                                id_label = @id_label,  
                                id_status = @id_status 
                                WHERE id_note = @id_note";
                using (NpgsqlCommand cmd = new NpgsqlCommand(update, Connection))
                {
                    cmd.Parameters.AddWithValue("@id_note", note.IdNote);
                    cmd.Parameters.AddWithValue("@note_name", note.NoteName);
                    cmd.Parameters.AddWithValue("@content", note.Content);
                    cmd.Parameters.AddWithValue("@image_url", note.ImageUrl ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@time_created", note.TimeCreated);
                    cmd.Parameters.AddWithValue("@pinned", note.Pinned);
                    cmd.Parameters.AddWithValue("@id_user", note.IdUser);
                    cmd.Parameters.AddWithValue("@id_label", note.IdLabel);
                    cmd.Parameters.AddWithValue("@id_status", note.IdStatus);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed! Error: " + ex.Message);
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
                string delete = @"DELETE FROM notes WHERE id_note = @id_note";
                using (NpgsqlCommand cmd = new NpgsqlCommand(delete, Connection))
                {
                    cmd.Parameters.AddWithValue("@id_note", idNote);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed! Error: " + ex.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }

        public bool UpdateIdLabel(int idNote, int idLabel)
        {
            try
            {
                Connection.Open();
                string update = @"UPDATE notes SET id_label = @id_label WHERE id_note = @id_note";
                using (NpgsqlCommand cmd = new NpgsqlCommand(update, Connection))
                {
                    cmd.Parameters.AddWithValue("@id_note", idNote);
                    cmd.Parameters.AddWithValue("@id_label", idLabel);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Label failed! Error: " + ex.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }

    }
}
