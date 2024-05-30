using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using notfiy.Core;
using notfiy.Entities;
using notfiy.Helpers;
using notfiy.Models;


namespace notfiy.Controllers
{
    class NoteController
    {
        NoteModel NoteModel;
        public NoteController()
        {
            NoteModel = new NoteModel();
        }
        public int CreateNote(string noteName, string content, string? imageFileName, int idUser, int idLabel, int idStatus){
            
            string? imageUrl = ProcessImage(imageFileName);

            
            Note note = new Note(){
                NoteName = noteName,
                Content = content,
                ImageUrl = imageUrl,
                TimeCreated = Time.CurrentTimeStamp(),
                IdUser = SystemSingleton.Instance.UserLoggedIn.IdUser,
                IdStatus = (int) Helpers.Status.Default
            };

            return NoteModel.CreateNote(note);
        }

        public bool UpdateNote(int idNote, string noteName, string content, string? imageFileName, bool pinned, int idUser, int idLabel, int idStatus)
        {
            Note note = NoteModel.GetNoteById(idNote);

            string? imageUrl = ProcessImage(imageFileName);

            
            note.NoteName = noteName;
            note.Content = content;
            note.ImageUrl = imageUrl ?? note.ImageUrl; // Retain existing image URL if no new image is uploaded
            note.Pinned = pinned;
            note.IdLabel = idLabel;
            note.IdStatus = idStatus;

            return NoteModel.UpdateNote(note);
        }

        public bool UpdateNotePin(int idNote, bool pinned)
        {
            Note note = NoteModel.GetNoteById(idNote);
            note.Pinned = pinned;
            return NoteModel.UpdateNote(note);

        } 

        public bool UpdateNoteStatus(int idNote, int id_status)
        {
            Note note = NoteModel.GetNoteById(idNote);
            note.IdStatus= id_status;
            return NoteModel.UpdateNote(note);
        } 

        public bool UpdateNoteLabel(int idNote, int id_label)
        {
            Note note = NoteModel.GetNoteById(idNote);
            note.IdLabel = id_label;
            return NoteModel.UpdateNote(note);
        } 

        public bool DeleteNote(int idNote)
        {
            return NoteModel.DeleteNote(idNote);
        } 

        private string? ProcessImage(string? imageFileName)
        {
            if (string.IsNullOrEmpty(imageFileName))
            {
                return null;
            }

            if (!File.Exists(imageFileName))
            {
                MessageBoxHelper.ShowErrorMessageBox($"Target File '{imageFileName}' Tidak Ada!");
                return null;
            }

            if (!Helpers.Image.IsImageFile(imageFileName))
            {
                MessageBoxHelper.ShowErrorMessageBox($"Target File '{imageFileName}' Bukan Gambar!");
                return null;
            }

            string? imageUrl = Helpers.Image.UploadImage(imageFileName);
            if (imageUrl == null)
            {
                MessageBoxHelper.ShowErrorMessageBox("Tidak Dapat Mengupload Gambar!");
            }

            return imageUrl;
        }


    }
}