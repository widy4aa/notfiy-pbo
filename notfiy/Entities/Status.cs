using notfiy.Core;

namespace notfiy.Entities
{
    class Status : Entity
    {
        public int IdStatus { get; set; }
        public required string StatusName { get; set; }
    }
}