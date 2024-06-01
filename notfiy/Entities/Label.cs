using notfiy.Core;

namespace notfiy.Entities
{
    public class Label : Entity
    {
        public int IdLabel { get; set; }
        public required string LabelName { get; set; }
    }
}