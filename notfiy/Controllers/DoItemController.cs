using notfiy.Core;
using notfiy.Entities;
using notfiy.Models;
using notfiy.Views.AddToDoList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace notfiy.Controllers
{
    class DoItemController : DoItemEdit
    {
        private DoItemModel DoItemModel;

        public DoItemController()
        {
            DoItemModel = new DoItemModel();
        }

        //public bool ReadDoItem()
        //{
        //    DoItem doItem = new DoItem()
        //    {

        //    };

        //    return doItemModel.ReadDoItem(doItem);
        //}

        public List<DoItem> GetAllDoItems(int idTodolist)
        {
            return DoItemModel.GetAllDoItems(idTodolist);
        }

        public int CreateDoItem(string doItemName, bool Checked, int idTodoList)
        {
            DoItem doItem = new DoItem()
            {
                DoItemName = doItemName,
                Checked = Checked,
                IdTodoList = idTodoList
            };
            return DoItemModel.CreateDoItem(doItem);
        }

        public bool UpdateDoItem(int idDoItem, string doItemName, bool Checked, int idTodoList)
        {
            DoItem doItem = new DoItem()
            {
                IdDoItem = idDoItem,
                DoItemName = doItemName,
                Checked = Checked,
                IdTodoList = idTodoList
            };
            return DoItemModel.UpdateDoItem(doItem);
        }

        public bool DeleteDoItem(int idTodoList)
        {
            return DoItemModel.DeleteDoItem(idTodoList);
        }

        public bool DoItemCheck(int idTodoList, bool Checked)
        {
            return DoItemModel.DoItemCheck(idTodoList, Checked);
        }

        //public string TextBoxvalue()
        //{
        //    return TextBoxValue(kryptonTextBox1.Text);
        //}

        public bool CheckBoxvalue()
        {
            return CheckBoxValue;
        }
    }
}