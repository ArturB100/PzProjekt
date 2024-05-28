using PzProjekt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.views.Arena
{
    public partial class TournamentView : UserControlBase
    {
        private Tournament tournament ;
        public TournamentView(ProgramCtx programCtx)  : base(programCtx, false) 
        {
            InitializeComponent();
            tournament = ProgramCtx.ActiveTournament;

            title.Text = tournament.ToString();
            playerTextBox.Text = ProgramCtx.SelectedCharacter.DisplayInformations();
            enemyTextBox.Text = tournament.ShowNextEnemy().DisplayInformations();
        }

        public void nextFightBtn_Click (object sender, EventArgs e)
        {
            Fight fight = tournament.CreateNextFightToDeath(ProgramCtx.SelectedCharacter);
            ProgramCtx.ChangeView(new FightView(ProgramCtx, fight));
        }
    }
}
