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

namespace WinForm.views
{
    public partial class CreateCharacterView : UserControlBase
    {
        List<Label> pointsLabels = new List<Label>()
        {

        };

        public PzProjekt.Character character { get; set; }

        public CreateCharacterView(ProgramCtx form) : base(form)
        {
            InitializeComponent();
            UpdateCharacterPointsToInvestLabel();
            pointsLabels.AddRange(new List<Label>()
            {
                intelligenceCurrentValue, strengthCurrentValue, AgilityCurrentValue, AttackCurrentValue, defenceCurrentValue, vitalityCurrentValue, charismaCurrentValue, staminaCurrentValue, magicaCurrentValue
            });
            character = ProgramCtx.SelectedCharacter;
            UpdateCharacterStatisticsLabels();


            try
            {
                //characterHeadImage.Image = Image.FromFile("glowaTest.jpg");
            }
            catch (Exception ex)
            {
                ProgramCtx.WarningMessage(ex.Message);
            }
        }

        public CreateCharacterView() { }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CreateCharacterView_Load(object sender, EventArgs e)
        {

        }

        private void UpdateCharacterStatisticsLabels()
        {
            CharacterStatistics characterStatistics = character.BaseStatistics;
            intelligenceCurrentValue.Text = characterStatistics.Intelligence.ToString();
            strengthCurrentValue.Text = characterStatistics.Strength.ToString();
            AgilityCurrentValue.Text = characterStatistics.Agility.ToString();
            AttackCurrentValue.Text = characterStatistics.Attack.ToString();
            defenceCurrentValue.Text = characterStatistics.Defence.ToString();
            vitalityCurrentValue.Text = characterStatistics.Vitality.ToString();
            charismaCurrentValue.Text = characterStatistics.Charisma.ToString();
            staminaCurrentValue.Text = characterStatistics.Stamina.ToString();
            magicaCurrentValue.Text = characterStatistics.Magica.ToString();

        }

        private void UpdateCharacterPointsToInvestLabel()
        {
            pointsToInvestLabel.Text = Convert.ToString(ProgramCtx.SelectedCharacter.Parameters.PointsToInvest);
        }

        private delegate void SetStatisticDelegate(int value);
        private void ChangeStatistic(SetStatisticDelegate setStatisticDelegate, int value)
        {
            if (character.Parameters.PointsToInvest == 0 && value > 0)
            {
                ProgramCtx.WarningMessage("brak punktow");
                return;
            }


            try
            {
                setStatisticDelegate(value);
            }
            catch (NegativeStatisticPointsException exception)
            {
                ProgramCtx.WarningMessage("nie moze byc mniej niz 1");
                return;
            }

            // operation succed, so we change the points to invest number
            if (value > 0)
            {
                character.Parameters.PointsToInvest -= 1;
            }
            else
            {
                character.Parameters.PointsToInvest += 1;
            }


            UpdateCharacterStatisticsLabels();
            UpdateCharacterPointsToInvestLabel();
        }

        private void UpdateHeadImage ()
        {
            characterHeadImage.Image = Image.FromFile(character.HeadImage);
        }

        private void strengthMinusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.BaseStatistics.Strength += value; }, -1);
        }

        private void strengthPlusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.BaseStatistics.Strength += value; }, 1);
        }

        private void agilityMinusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.BaseStatistics.Agility += value; }, -1);
        }

        private void agilityPlusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.BaseStatistics.Agility += value; }, 1);
        }

        private void attackMinusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.BaseStatistics.Attack += value; }, -1);
        }

        private void attackPlusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.BaseStatistics.Attack += value; }, 1);
        }

        private void defenceMinusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.BaseStatistics.Defence += value; }, -1);
        }

        private void defencePlusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.BaseStatistics.Defence += value; }, 1);
        }

        private void vitalityMinusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.BaseStatistics.Vitality += value; }, -1);
        }

        private void vitalityPlusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.BaseStatistics.Vitality += value; }, 1);
        }

        private void charismaMinusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.BaseStatistics.Charisma += value; }, -1);
        }

        private void charismaPlusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.BaseStatistics.Charisma += value; }, 1);
        }

        private void staminaMinusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.BaseStatistics.Stamina += value; }, -1);
        }

        private void staminaPlusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.BaseStatistics.Stamina += value; }, 1);
        }

        private void magicaMinusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.BaseStatistics.Magica += value; }, -1);
        }

        private void magicaPlusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.BaseStatistics.Magica += value; }, 1);
        }

        private void intelligenceMinusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.BaseStatistics.Intelligence += value; }, -1);
        }

        private void intelligencePlusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.BaseStatistics.Intelligence += value; }, -1);
        }

        private void nameInp_TextChanged(object sender, EventArgs e)
        {
            character.Name = nameInp.Text;
        }

        private void nextViewBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(character.Name) && character.Parameters.PointsToInvest == 0)
            {
                if (ProgramCtx.PlayableCharacters == null)
                {
                    ProgramCtx.WarningMessage("null");
                }
                ProgramCtx.PlayableCharacters.Add(character);
                ProgramCtx.ChangeView(new HomeView(ProgramCtx));
                
            }
            else
            {
                ProgramCtx.WarningMessage("Podaj imie, oraz rozdaj wszystkie punkty umiejętności");
            }


        }

        private void uploadHeadImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog.FileName;

                    string fileName = Path.GetFileName(filePath);

                    string destinationDirectory = "";

                    string destinationPath = Path.Combine(destinationDirectory, fileName);

                    character.HeadImage = fileName;

                    File.Copy(filePath, destinationPath);

                    UpdateHeadImage();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
