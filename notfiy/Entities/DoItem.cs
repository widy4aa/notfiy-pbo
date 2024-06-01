using notfiy.Core;
using System.Web;

namespace notfiy.Entities
{
    class DoItem : Entity
    {
        public int IdDoItem;
        public string DoItemName;
        public bool Checked;
        public int IdTodoList;
    }
}