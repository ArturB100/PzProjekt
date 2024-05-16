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

namespace WinForm.views.shops
{
    public partial class ArmourShopView : UserControlBase
    {

        private Armour selectedArmour;
        private Shop<Armour> armourShop;

        private int armourTypeChoose = 0;

        private List<Armour> currentArmourFilteredList = new List<Armour>();

        public ArmourShopView(ProgramCtx programCtx)
        {
            InitializeComponent();
            ProgramCtx = programCtx;
            armourShop = programCtx.GameSetup.ArmourShop;
            //resultsBox.DataSource = ProgramCtx.GameSetup.ArmourShop.GetItemsAsString();
            resultsBox.Visible = false;
        }

        private void resultsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = resultsBox.SelectedIndex;
            selectedArmour = currentArmourFilteredList[selectedIndex];

        }

        public bool CheckIfSelectedItemCanBeBought()
        {
            return
            (
                selectedArmour != null &&
                armourShop.CanBeBoughtByPlayer(ProgramCtx.SelectedCharacter, selectedArmour)
            );
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            if (CheckIfSelectedItemCanBeBought())
            {
                armourShop.BuyItem(ProgramCtx.SelectedCharacter, selectedArmour);
                ProgramCtx.SuccessMessage("przedmiot zostal zakupiony");
            }
            else
            {
                ProgramCtx.WarningMessage("Cos poszlo nie tak");
            }

        }

        private void ekranGlownyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgramCtx.ChangeView(new HomeView(ProgramCtx));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SetUserChoose(1);
        }

        private void chestplatePic_Click(object sender, EventArgs e)
        {
            SetUserChoose(2);
        }

        private void leggingsPic_Click(object sender, EventArgs e)
        {
            SetUserChoose(3);
        }

        private void bootsPic_Click(object sender, EventArgs e)
        {
            SetUserChoose(4);
        }

        private void SetUserChoose (int choose)
        {
            DeleteAllBordersFromPictures();

            armourTypeChoose = choose;

            if (choose == 0) return;

            resultsBox.Visible = true;

            switch (choose)
            {
                case 1:
                    currentArmourFilteredList = armourShop.GetItems().FindAll(item => item.ArmourType == ArmourType.Helmet);
                    helmetsPic.BorderStyle = BorderStyle.FixedSingle;                   
                    helmetsPic.BackColor = Color.Yellow;
                    break;
                case 2:
                    currentArmourFilteredList = armourShop.GetItems().FindAll(item => item.ArmourType == ArmourType.Chestplate);
                    chestplatePic.BorderStyle = BorderStyle.FixedSingle;
                    chestplatePic.BackColor = Color.Yellow;
                    break;
                case 3:
                    currentArmourFilteredList = armourShop.GetItems().FindAll(item => item.ArmourType == ArmourType.Leggings);
                    leggingsPic.BorderStyle = BorderStyle.FixedSingle;
                    leggingsPic.BackColor = Color.Yellow;
                    break;
                case 4:
                    currentArmourFilteredList = armourShop.GetItems().FindAll(item => item.ArmourType == ArmourType.Boots);
                    bootsPic.BorderStyle = BorderStyle.FixedSingle;
                    bootsPic.BackColor = Color.Yellow;
                    break;

            }

            resultsBox.DataSource = currentArmourFilteredList.GetItemsAsString();
        }

        private void DeleteAllBordersFromPictures ()
        {
            helmetsPic.BorderStyle= BorderStyle.None;
            chestplatePic.BorderStyle = BorderStyle.None;
            leggingsPic.BorderStyle = BorderStyle.None;
            bootsPic.BorderStyle = BorderStyle.None;

            helmetsPic.BackColor = Color.Transparent;
            chestplatePic.BackColor = Color.Transparent;
            leggingsPic.BackColor = Color.Transparent;
            bootsPic.BackColor = Color.Transparent;

        }
    }
}
