using notfiy.Entities;
using notfiy.Models;
using notfiy.Views.Todolist;

namespace notfiy.Controllers
{
    class TodolistController
    {
        private readonly TodoListModel todolistModel;
        private readonly TodolistControl todolistView;
        
        public TodolistController()
        {
            todolistModel = new TodoListModel();
            todolistView = new TodolistControl();
        }

        public List<TodoList> GetAllTodoList()
        {
            return todolistModel.GetAllTodoList();
        }

        public TodoList? GetTodoList(int idTodolist)
        {
            return todolistModel.GetTodoList(idTodolist);
        }

        public int CreateTodoList(TodoList todoList)
        {
            return todolistModel.CreateTodoList(todoList);
        }

        public bool UpdateTodoList(TodoList todoList)
        {
            return todolistModel.UpdateTodoList(todoList);
        }

        public bool DeleteTodoList(int idTodoList)
        {
            return todolistModel.DeleteTodoList(idTodoList);
        }

        //public bool UpdateTodoListPin(int idTodoList, bool pinned)
        //{
            
        //}
    }


}