using Microsoft.VisualBasic.ApplicationServices;
using notfiy.Entities;
using notfiy.Models;
using notfiy.Views.Todolist;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace notfiy.Controllers
{
    class TodolistController
    {
        private TodoListModel todolistModel;
        //private TodolistControl todolistView;
        
        public TodolistController()
        {
            todolistModel = new TodoListModel();
            //todolistView = new TodolistControl();
        }

        public List<TodoList> GetAllTodoList()
        {
            return todolistModel.GetAllTodoList();
        }

        public TodoList? GetTodoList(int idTodolist)
        {
            return todolistModel.GetTodoList(idTodolist);
        }

        public int CreateTodoList(string todoListName, string timeCreated, int idUser, int idStatus, bool pinned)
        {
            TodoList todoList = new TodoList()
            {
                TodoListName = todoListName,
                TimeCreated = timeCreated,
                IdUser = idUser,
                IdStatus = idStatus,
                Pinned = pinned ? 1:0
            };
            return todolistModel.CreateTodoList(todoList);
        }

        public bool UpdateTodoList(int idTodoList, string todoListName, string timeCreated, int idUser, int idStatus, bool pinned)
        {
            TodoList todoList = new TodoList()
            {
                IdTodoList = idTodoList,
                TodoListName = todoListName,
                TimeCreated = timeCreated,
                IdUser = idUser,
                IdStatus = idStatus,
                Pinned = pinned ? 1 : 0
            };
            return todolistModel.UpdateTodoList(todoList);
        }

        public bool DeleteTodoList(int idTodoList)
        {
            return todolistModel.DeleteTodoList(idTodoList);
        }

        public bool UpdateTodoListPin(int idTodoList, bool pinned)
        {
            return todolistModel.UpdateTodoListPin(idTodoList, pinned);
        }
    }


}