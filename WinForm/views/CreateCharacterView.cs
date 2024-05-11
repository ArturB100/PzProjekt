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

        public CreateCharacterView(Form1 form) : base(form)
        {
            InitializeComponent();
            UpdateCharacterPointsToInvestLabel();
            pointsLabels.AddRange(new List<Label>()
            {
                intelligenceCurrentValue, strengthCurrentValue, AgilityCurrentValue, AttackCurrentValue, defenceCurrentValue, vitalityCurrentValue, charismaCurrentValue, staminaCurrentValue, magicaCurrentValue
            });
            character = MainForm.SelectedCharacter;
            UpdateCharacterStatisticsLabels();


            try
            {
                //characterHeadImage.Image = Image.FromFile("glowaTest.jpg");
            }
            catch (Exception ex)
            {
                MainForm.WarningMessage(ex.Message);
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
            Statistics statistics = character.CharacterStatistics;
            intelligenceCurrentValue.Text = statistics.Intelligence.ToString();
            strengthCurrentValue.Text = statistics.Strength.ToString();
            AgilityCurrentValue.Text = statistics.Agility.ToString();
            AttackCurrentValue.Text = statistics.Attack.ToString();
            defenceCurrentValue.Text = statistics.Defence.ToString();
            vitalityCurrentValue.Text = statistics.Vitality.ToString();
            charismaCurrentValue.Text = statistics.Charisma.ToString();
            staminaCurrentValue.Text = statistics.Stamina.ToString();
            magicaCurrentValue.Text = statistics.Magica.ToString();

        }

        private void UpdateCharacterPointsToInvestLabel()
        {
            pointsToInvestLabel.Text = Convert.ToString(MainForm.SelectedCharacter.PointToInvest);
        }

        private delegate void SetStatisticDelegate(int value);
        private void ChangeStatistic(SetStatisticDelegate setStatisticDelegate, int value)
        {
            if (character.PointToInvest == 0 && value > 0)
            {
                MainForm.WarningMessage("brak punktow");
                return;
            }


            try
            {
                setStatisticDelegate(value);
            }
            catch (NegativeStatisticPointsException exception)
            {
                MainForm.WarningMessage("nie moze byc mniej niz 1");
                return;
            }

            // operation succed, so we change the points to invest number
            if (value > 0)
            {
                character.PointToInvest -= 1;
            }
            else
            {
                character.PointToInvest += 1;
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
            ChangeStatistic((value) => { character.CharacterStatistics.Strength += value; }, -1);
        }

        private void strengthPlusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.CharacterStatistics.Strength += value; }, 1);
        }

        private void agilityMinusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.CharacterStatistics.Agility += value; }, -1);
        }

        private void agilityPlusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.CharacterStatistics.Agility += value; }, 1);
        }

        private void attackMinusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.CharacterStatistics.Attack += value; }, -1);
        }

        private void attackPlusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.CharacterStatistics.Attack += value; }, 1);
        }

        private void defenceMinusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.CharacterStatistics.Defence += value; }, -1);
        }

        private void defencePlusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.CharacterStatistics.Defence += value; }, 1);
        }

        private void vitalityMinusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.CharacterStatistics.Vitality += value; }, -1);
        }

        private void vitalityPlusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.CharacterStatistics.Vitality += value; }, 1);
        }

        private void charismaMinusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.CharacterStatistics.Charisma += value; }, -1);
        }

        private void charismaPlusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.CharacterStatistics.Charisma += value; }, 1);
        }

        private void staminaMinusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.CharacterStatistics.Stamina += value; }, -1);
        }

        private void staminaPlusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.CharacterStatistics.Stamina += value; }, 1);
        }

        private void magicaMinusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.CharacterStatistics.Magica += value; }, -1);
        }

        private void magicaPlusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.CharacterStatistics.Magica += value; }, 1);
        }

        private void intelligenceMinusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.CharacterStatistics.Intelligence += value; }, -1);
        }

        private void intelligencePlusBtn_Click(object sender, EventArgs e)
        {
            ChangeStatistic((value) => { character.CharacterStatistics.Intelligence += value; }, -1);
        }

        private void nameInp_TextChanged(object sender, EventArgs e)
        {
            character.Name = nameInp.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(character.Name) && character.PointToInvest == 0)
            {
                MainForm.ChangeView(new HomeView(MainForm));
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
