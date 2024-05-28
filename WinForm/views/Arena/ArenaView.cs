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
        private List<PzProjekt.Tournament> tournaments;
        private PzProjekt.Tournament selectedTournament;
        public ArenaView(ProgramCtx programCtx) : base(programCtx, true)
        {
            InitializeComponent();
            player = ProgramCtx.SelectedCharacter;
            tournaments = ProgramCtx.GameSetup.DataFeeder.GetTournaments(ProgramCtx.SelectedCharacter);
            tournamentsList.DataSource = tournaments;
        }



        private void trainingFightBtn_Click_1(object sender, EventArgs e)
        {
            DataFeeder dataFeeder = ProgramCtx.GameSetup.DataFeeder;
            Character enemy = CharacterFactory.CreateRandomCharacterBasedOnLevel(
                player.Parameters.Level,
                DataFeeder.swords,
                DataFeeder.axes,
                DataFeeder.helmets,
                DataFeeder.chestplates,
                DataFeeder.leggings,
                DataFeeder.boots,
                DataFeeder.spells,
                DataFeeder.effects

                );

            FightToFirstBlood fight = new FightToFirstBlood(player, enemy);


            ProgramCtx.ChangeView(new FightView(ProgramCtx, fight));

        }

        private void tournamentFightBtn_Click(object sender, EventArgs e)
        {
            if (selectedTournament == null)
            {
                ProgramCtx.WarningMessage("Wybierz turniej");
                return;
            }
            ProgramCtx.ActiveTournament = selectedTournament;

            GameSetup gameSetup = ProgramCtx.GameSetup;
            selectedTournament.InitializeEnemies
            (
                gameSetup.DataFeeder.GetWeapons().FindAll(w => w.WeaponType == WeaponType.Sword),
                gameSetup.DataFeeder.GetWeapons().FindAll(w => w.WeaponType == WeaponType.Axe),
                gameSetup.DataFeeder.GetArmours().FindAll(w => w.ArmourType == ArmourType.Helmet),
                gameSetup.DataFeeder.GetArmours().FindAll(w => w.ArmourType == ArmourType.Chestplate),
                gameSetup.DataFeeder.GetArmours().FindAll(w => w.ArmourType == ArmourType.Leggings),
                gameSetup.DataFeeder.GetArmours().FindAll(w => w.ArmourType == ArmourType.Boots),
                gameSetup.DataFeeder.GetSpells(),
                gameSetup.DataFeeder.GetEffects()
            );


            ProgramCtx.ChangeView(new TournamentView(ProgramCtx));
        }

        private void tournamentsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTournament = tournaments[tournamentsList.SelectedIndex];
        }
    }
}
