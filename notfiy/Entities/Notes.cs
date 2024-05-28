namespace notfiy.Entities
{
    public class Notes
    {
        public int IdNote { get; set; }
        public string Note {  get; set; }
        public string ImageFileName { get; set; }
        public string NoteTimeCreated {  get; set; }
        public int IdUsers {  get; set; }
        public int IdLabels {  get; set; }
        public int IdPinnedItems { get; set; }
        public  int IdNoteStatus {  get; set; }
    }
}
