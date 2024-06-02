using Microsoft.VisualBasic.ApplicationServices;
using notfiy.Core;
using notfiy.Entities;
using notfiy.Models;

using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace notfiy.Controllers
{
    class TodoListController
    {
        private TodoListModel TodoListModel;
        //private TodoListControl todoListView;
        
        public TodoListController()
        {
            TodoListModel = new TodoListModel();
            //todoListView = new TodoListControl();
        }

        public List<TodoList> GetAllTodoList()
        {
            return TodoListModel.GetAllTodoList();
        }

        public TodoList? GetTodoList(int idTodoList)
        {
            return TodoListModel.GetTodoList(idTodoList);
        }

        public int CreateTodoList(string todoListName, int idStatus)
        {
            TodoList todoList = new TodoList()
            {
                TodoListName = todoListName,
                TimeCreated = DateTime.Now,
                IdUser = SystemSingleton.Instance.UserLoggedIn.IdUser,
                IdStatus = idStatus,
            };
            return TodoListModel.CreateTodoList(todoList);
        }

        public bool UpdateTodoList(int idTodoList, string todoListName, int idStatus)
        {
            TodoList todoList = GetTodoList(idTodoList);

                todoList.IdTodoList = idTodoList;
                todoList.TodoListName = todoListName;
                todoList.IdUser = SystemSingleton.Instance.UserLoggedIn.IdUser;
                todoList.IdStatus = idStatus;
            
            return TodoListModel.UpdateTodoList(todoList);
        }

        public bool DeleteTodoList(int idTodoList)
        {
            return TodoListModel.DeleteTodoList(idTodoList);
        }

        public bool UpdateTodoListPin(int idTodoList, bool pinned)
        {
            return TodoListModel.UpdateTodoListPin(idTodoList, pinned);
        }

        public bool UpdateTodoListStatus(int idTodoList, int id_status)
        {
            TodoList todoList = TodoListModel.GetTodoList(idTodoList);
            todoList.IdStatus = id_status;
            return TodoListModel.UpdateTodoList(todoList);
        } 
    }


}