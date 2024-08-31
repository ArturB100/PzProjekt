using PzProjekt;
using PzProjekt.exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.views.shops
{
    public partial class ChurchView : UserControlBase
    {
        private Character character;
        private CharacterStatistics characterStatistics;
        public ChurchView(ProgramCtx programCtx) : base(programCtx, true)
        {
            InitializeComponent();
            character = ProgramCtx.SelectedCharacter;
            characterStatistics = character.BaseStatistics;
            PrintCurrentCharacterStatistics();
        }

        public void PrintCurrentCharacterStatistics()
        {
            pointsLabel.Text = $"Punkty do wydania: {character.Parameters.PointsToInvest}";

            strengthCurVal.Text = characterStatistics.Strength.ToString();
            agilityCurVal.Text = characterStatistics.Agility.ToString();

            attackCurVal.Text = characterStatistics.Attack.ToString();
            defenceCurVal.Text = characterStatistics.Defence.ToString();
            vitalityCurVal.Text = characterStatistics.Vitality.ToString();
            charismaCurVal.Text = characterStatistics.Charisma.ToString();
            staminaCurVal.Text = characterStatistics.Stamina.ToString();
            magicaCurVal.Text = characterStatistics.Magica.ToString();
        }

        private void InvestPoint (int dictionaryIndex)
        {
            try
            {
                character.InvestPoint(dictionaryIndex);
            } 
            catch (NoPointsToInvestException ex)
            {
                WarningMessage("brak punktów do wydania");
            }
            PrintCurrentCharacterStatistics();
        }


        private void strengthBtn_Click(object sender, EventArgs e)
        {
            InvestPoint(0);
        }

        private void attackBtn_Click(object sender, EventArgs e)
        {
            InvestPoint(2);
        }

        private void agilityBtn_Click(object sender, EventArgs e)
        {
            InvestPoint(1);
        }

        private void defenceBtn_Click(object sender, EventArgs e)
        {
            InvestPoint(3);
        }

        private void vitalityBtn_Click(object sender, EventArgs e)
        {
            InvestPoint(4);
        }

        private void charismaBtn_Click(object sender, EventArgs e)
        {
            InvestPoint(5);
        }

        private void staminaBtn_Click(object sender, EventArgs e)
        {
            InvestPoint(6);
        }

        private void magicaBtn_Click(object sender, EventArgs e)
        {
            InvestPoint(7);
        }

        private void intelligenceBtn_Click(object sender, EventArgs e)
        {
            InvestPoint(8);
        }
    }
}
