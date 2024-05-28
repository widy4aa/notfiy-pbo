namespace notfiy.Entities
{
    public class TodoLists
    {
        public int IdTodoList { get; set; }
        public string TodoListName { get; set; }
        public string TimeCreated { get; set; }
        public int IdUser { get; set; }
        public int IdTodoListStatus { get; set; }
        public int IdPinnedItem { get; set; }
    }
}