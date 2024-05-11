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
            set
            {
                mainText = value;
                // Update label text when MainText changes
                label.Text = mainText;
            }
        }
        private Label label;
        private Button button;
        public GameSelectPanel() : base()
        { 
            this.Size = new System.Drawing.Size(888, 174);
            label = new Label();
            label.Text = MainText;
            label.AutoSize = true;
            label.Location = new Point(10, 10);

            button.Text = "Graj";
            button.Location = new Point(12, 10);

            button.Click += Button_Click;

            this.Controls.Add(label);
            this.Controls.Add(button);

        }

        private void Button_Click(object? sender, EventArgs e)
        {

            throw new NotImplementedException();
        }
    }
}
