using notfiy.Entities;
using notfiy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace notfiy.Controllers
{
    class DoItemController
    {
        private DoItemModel doItemModel;

        public DoItemController()
        {
            doItemModel = new DoItemModel();
        }

        public int CreateDoItem(string doItemName, bool Checked, int idTodoList)
        {
            DoItem doItem = new DoItem()
            {
                DoItemName = doItemName,
                Checked = Checked,
                IdTodoList = idTodoList
            };
            return doItemModel.CreateDoItem(doItem);
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
            return doItemModel.UpdateDoItem(doItem);
        }

        public bool DeleteDoItem(int idTodoList)
        {
            return doItemModel.DeleteDoItem(idTodoList);
        }

        public bool DoItemCheck(int idTodoList, bool Checked)
        {
            return doItemModel.DoItemCheck(idTodoList, Checked);
        }
    }
}