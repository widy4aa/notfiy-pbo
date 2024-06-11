using notfiy.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notfiy.Views.Archive
{
    public partial class ArchiveDetail : UserControl
    {
        Note Note;
        public ArchiveDetail(Note note)
        {
            Note = note;
            InitializeComponent();
        }
    }
}
