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
    public partial class SelectedCharacterDetailsView : UserControlBase
    {
        public SelectedCharacterDetailsView(ProgramCtx programCtx) : base(programCtx, true)
        {
            InitializeComponent();

            characterDetails.Text = ProgramCtx.SelectedCharacter.DisplayInformations();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgramCtx.ChangeView(new HomeView(ProgramCtx));
        }

        private void characterDetails_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
