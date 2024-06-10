using notfiy.Core;
using notfiy.Entities;
using notfiy.Models;
using notfiy.Helpers;

namespace notfiy.Controllers
{
    class NoteController
    {
        NoteModel NoteModel;
        ImageController ImageController;

        public NoteController()
        {
            NoteModel = new NoteModel();
            ImageController = new ImageController();
        }

        public List<Note> GetAllNote()
        {
            return NoteModel.GetAllNote(SystemSingleton.Instance.UserLoggedIn.IdUser, (int) Helpers.Status.Default);
        }

        public int CreateNote(string noteName, string content, string? imageUrl, int? idLabel, int idStatus)
        {

            

            Note note = new Note()
            {
                NoteName = noteName,
                Content = content,
                ImageUrl = imageUrl,
                TimeCreated = DateTime.Now,
                IdUser = SystemSingleton.Instance.UserLoggedIn.IdUser,
                IdStatus = idStatus,
                IdLabel = idLabel
            };



            int idNewNote = NoteModel.CreateNote(note);
            if(imageUrl != null)
            {
                ImageController.ProcessImage(idNewNote, imageUrl);
            }
            return idNewNote;
        }

        public string? GetImage(int idNote)
        {
            Note ?note = NoteModel.GetNoteById(idNote);
            if (note == null || string.IsNullOrEmpty(note.ImageUrl))
            {
                return null; // Note not found or no image URL
            }

            return ImageController.ProcessImage(idNote, note.ImageUrl);
        }

        public bool UpdateNote(int idNote, string noteName, string content, string? imageFileName, bool pinned, int idLabel, int idStatus)
        {
            Note ?note = NoteModel.GetNoteById(idNote);

            string? imageUrl = ImageController.UploadImage(imageFileName);

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
            note.IdStatus = id_status;
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

        public Note? GetNote(int idNote) 
        {
            return NoteModel.GetNoteById(idNote);
        }

        public int CopyNoteToUser(int idNote, int targetIdUser)
        {
            Note note = NoteModel.GetNoteById(idNote);
            note.IdUser = targetIdUser;
            note.IdNote = 0;
            return NoteModel.CreateNote(note);
        }
    }
}
