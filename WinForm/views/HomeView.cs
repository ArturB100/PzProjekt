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
    public partial class HomeView : UserControlBase
    {

        public HomeView(Form1 form) : base(form)
        {
            InitializeComponent();
        }


        public HomeView()
        {
            InitializeComponent();
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm.SaveGame();
        }

        private void wyjdzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm.SaveGame();
            MainForm.SelectedCharacter = null;
            MainForm.ChangeView(new FirstPage(MainForm));
        }

        private void weponsmithBtn_Click(object sender, EventArgs e)
        {
            ProgramCtx.ChangeView(new WeaponsmithView(ProgramCtx));
        }
    }
}
