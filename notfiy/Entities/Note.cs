using notfiy.Core;

namespace notfiy.Entities
{
    public class Note : Entity
    {
        public int IdNote { get; set; }
        public required string NoteName { get; set; }
        public required string Content { get; set; }
        public string? ImageUrl { get; set; } = null; // Allowing ImageFileName to be nullable
        public required DateTime TimeCreated { get; set; }
        public bool Pinned { get; set; }
        public int IdUser { get; set; }
        public int? IdLabel { get; set; } = null;
        public int IdStatus { get; set; }
    }
}