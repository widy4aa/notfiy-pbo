namespace notfiy.Entities
{
    public class Note
    {
        public int IdNote { get; set; }
        public string NoteName {  get; set; }
        public string ImageFileName { get; set; }
        public string NoteTimeCreated {  get; set; }
        public int IdUsers {  get; set; }
        public int IdLabels {  get; set; }
        public int IdPinnedItems { get; set; }
        public  int IdNoteStatus {  get; set; }
    }
}
