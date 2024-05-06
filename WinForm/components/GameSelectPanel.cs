using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.components
{
    class GameSelectPanel : Panel
    {
        private string mainText;

        public string MainText
        {
            get { return mainText; }
            set { mainText = value; }
        }

        public GameSelectPanel() 
        { 
            this.Size = new System.Drawing.Size(888, 174);
            Label label = new Label();
            label.Text = MainText;
            label.AutoSize = true;
            label.Location = new Point(10, 10); // Set th

            this.Controls.Add(label);
        }
    }
}
