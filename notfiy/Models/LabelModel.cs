using notfiy.Core;
using notfiy.Helpers;
using Npgsql;
using LabelEntity = notfiy.Entities.Label;
using System.Diagnostics;


namespace notfiy.Models
{
    class LabelModel : Model
    {

        public List<LabelEntity> GetAllLabels(int idUser)
        {
            var labels = new List<LabelEntity>();

            try
            {
                Connection.Open();
                using (var cmd = new NpgsqlCommand("SELECT id_label, label_name FROM labels WHERE id_user = @idUser", Connection))
                {
                    cmd.Parameters.AddWithValue("idUser", idUser);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            labels.Add(new LabelEntity
                            {
                                IdLabel = reader.GetInt32(0),
                                LabelName = reader.GetString(1)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowErrorMessageBox($"Error retrieving labels: {ex.Message}");
                // Optionally, rethrow the exception or handle it as needed.
            }
            finally
            {
                Connection.Close();
            }

            return labels;
        }


        public int CreateLabel(LabelEntity label, int idUser)
        {
            int newId = -1;
            try
            {
                Connection.Open();
                using (var cmd = new NpgsqlCommand("INSERT INTO labels (label_name, id_user) VALUES (@labelName, @idUser) RETURNING id_label", Connection))
                {
                    cmd.Parameters.AddWithValue("labelName", label.LabelName);
                    cmd.Parameters.AddWithValue("idUser", idUser);

                    newId = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowErrorMessageBox($"Error creating label: {ex.Message}");
                // Optionally, rethrow the exception or handle it as needed.
            }
            finally
            {
                Connection.Close();
            }

            return newId;
        }

        public bool DeleteLabel(int idLabel)
        {
            bool success = false;
            try
            {
                Connection.Open();
                using (var cmd = new NpgsqlCommand("DELETE FROM labels WHERE id_label = @idLabel", Connection))
                {
                    cmd.Parameters.AddWithValue("idLabel", idLabel);
                    int affectedRows = cmd.ExecuteNonQuery();
                    success = affectedRows > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowErrorMessageBox($"Error deleting label: {ex.Message}");
                // Optionally, rethrow the exception or handle it as needed.
            }
            finally
            {
                Connection.Close();
            }

            return success;
        }

        public int UpdateLabel(LabelEntity label)
        {
            int affectedRows = 0;
            try
            {
                Connection.Open();
                using (var cmd = new NpgsqlCommand("UPDATE labels SET label_name = @labelName WHERE id_label = @idLabel", Connection))
                {
                    cmd.Parameters.AddWithValue("labelName", label.LabelName);
                    cmd.Parameters.AddWithValue("idLabel", label.IdLabel);
                    affectedRows = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowErrorMessageBox($"Error updating label: {ex.Message}");
                // Optionally, rethrow the exception or handle it as needed.
            }
            finally
            {
                Connection.Close();
            }

            return affectedRows;
        }


        public LabelEntity? GetLabel(int idLabel)
        {
            LabelEntity label = null;

            try
            {
                Connection.Open();
                using (var cmd = new NpgsqlCommand("SELECT id_label, label_name FROM labels WHERE id_label = @idLabel", Connection))
                {
                    cmd.Parameters.AddWithValue("idLabel", idLabel);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            label = new LabelEntity
                            {
                                IdLabel = reader.GetInt32(0),
                                LabelName = reader.GetString(1)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowErrorMessageBox($"Error retrieving label: {ex.Message}");
                // Optionally, rethrow the exception or handle it as needed.
            }
            finally
            {
                Connection.Close();
            }

            return label;
        }
    }
}

