namespace notfiy.Entities
{
    public class Todolist
    {
        public int id_todolist { get; set; }
        public int users_id_user { get; set; }
        public string todolist_name { get; set; }
        public string timestamp { get; set; }
        public int id_todolist_status { get; set; }
        public int id_pin_item { get; set; }
    }
}