namespace notfiy.Entities
{
    public class Todolist
    {
        public int id_todolist { get; set; }
        public string todolist_name { get; set; }
        public string todolist_time_created { get; set; }
        public int id_users { get; set; }
        public int id_todolist_status { get; set; }
        public int id_pinned_item { get; set; }
    }
}