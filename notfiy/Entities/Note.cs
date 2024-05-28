namespace notfiy.Entities
{
    public class Note
    {
        public int IdNote { get; set; }
        public required string NoteName {  get; set; }
        public required string Content { get; set; }
        public string ?ImageFileName { get; set; }
        public required string TimeCreated {  get; set; }
        public int IdUser {  get; set; }
        public int IdLabel {  get; set; }
        public int IdPinnedItem { get; set; }
        public  int IdNoteStatus {  get; set; }
    }
}
