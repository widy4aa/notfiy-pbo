using notfiy.Core;
using notfiy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabelEntity = notfiy.Entities.Label;


namespace notfiy.Controllers
{
    class LabelController
    {
        private LabelModel LabelModel;

        public LabelController()
        {
            this.LabelModel = new LabelModel(); 
        }

        public List<LabelEntity> GetAllLabel()
        {
            return LabelModel.GetAllLabels(SystemSingleton.Instance.UserLoggedIn.IdUser);
        }
        public LabelEntity? GetLabel(int id)
        {
            return LabelModel.GetLabel(id); 
        }

        public int CreateLabel(string labelName)
        {
            LabelEntity label = new LabelEntity
            {
                LabelName = labelName
            };
            return LabelModel.CreateLabel(label, SystemSingleton.Instance.UserLoggedIn.IdUser);
        }

        public bool DeleteLabel(int idLabel)
        {
            return LabelModel.DeleteLabel(idLabel); 
        }


    }
}
