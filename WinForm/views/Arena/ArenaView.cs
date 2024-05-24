﻿using PzProjekt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.views.Arena;

namespace WinForm.views
{
    public partial class ArenaView : UserControlBase
    {
        private Character player;
        public ArenaView(ProgramCtx programCtx) : base(programCtx, true)
        {
            InitializeComponent();
            player = ProgramCtx.SelectedCharacter;


        }

       

        private void trainingFightBtn_Click_1(object sender, EventArgs e)
        {
            Character enemy = CharacterFactory.CreateRandomCharacterBasedOnLevel(player.Parameters.Level);

            FightToFirstBlood fight = new FightToFirstBlood(player, enemy);
            

            ProgramCtx.ChangeView(new FightView(ProgramCtx, fight));

        }
    }
}