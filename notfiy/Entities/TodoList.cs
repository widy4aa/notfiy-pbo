namespace notfiy.Entities
{
    public class TodoList
    {
        public int IdTodoList { get; set; }
        public required string TodoListName { get; set; }
        public required string TimeCreated { get; set; }
        public int IdUser { get; set; }
        public int IdStatus { get; set; }
        public int Pinned { get; set; }
    }
}