using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.views
{
    public partial class SinglePlayerGameSelectView : UserControlBase
    {
        List<Panel> panelList = new List<Panel>();
        
        public SinglePlayerGameSelectView() { }

        public SinglePlayerGameSelectView(Form1 form) : base(form)
        {
            InitializeComponent();
            panelList.Add(gameSelectPanel1);
            panelList.Add(gameSelectPanel2);

            for (int i = 0; i < form.SavedGames.Count; i++)
            {
                panelList[i].
            }
        }
    }
}
