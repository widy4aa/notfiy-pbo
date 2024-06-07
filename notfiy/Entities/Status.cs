using notfiy.Core;

namespace notfiy.Entities
{
    public class Status : Entity
    {
        public int IdStatus { get; set; }
        public required string StatusName { get; set; }
    }
}