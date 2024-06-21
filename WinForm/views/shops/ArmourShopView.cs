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
    public partial class ArmourShopView : BasicShopView
    {


        private Armour selectedArmour { get => (Armour)selectedInventoryItem; }


        private List<Armour> armours = new List<Armour>();

        public ArmourShopView(ProgramCtx programCtx) : base(programCtx)
        {
            InitializeComponent();


            armours = ProgramCtx.GameSetup.ArmourShop.GetItems();
            resultBox.Visible = false;

            OnBuyClick += ArmourShopView_OnBuyClick;
        }

        private void ArmourShopView_OnBuyClick()
        {
            ProgramCtx.GameSetup.ArmourShop.BuyItem(ProgramCtx.SelectedCharacter, selectedArmour);
            ProgramCtx.SuccessMessage("przedmiot zostal zakupiony");
        }

        public override bool CheckIfSelectedItemCanBeBought()
        {
            return
            (
                base.CheckIfSelectedItemCanBeBought() &&
                ProgramCtx.GameSetup.ArmourShop.CanBeBoughtByPlayer(ProgramCtx.SelectedCharacter, selectedArmour)
            );
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


            if (choose == 0) return;

            resultBox.Visible = true;

            Shop<Armour> armourShop = ProgramCtx.GameSetup.ArmourShop;

            switch (choose)
            {
                case 1:
                    armours = armourShop.GetItems().FindAll(item => item.ArmourType == ArmourType.Helmet);
                    helmetsPic.BorderStyle = BorderStyle.FixedSingle;                   
                    helmetsPic.BackColor = Color.Yellow;
                    break;
                case 2:
                    armours = armourShop.GetItems().FindAll(item => item.ArmourType == ArmourType.Chestplate);
                    chestplatePic.BorderStyle = BorderStyle.FixedSingle;
                    chestplatePic.BackColor = Color.Yellow;
                    break;
                case 3:
                    armours = armourShop.GetItems().FindAll(item => item.ArmourType == ArmourType.Leggings);
                    leggingsPic.BorderStyle = BorderStyle.FixedSingle;
                    leggingsPic.BackColor = Color.Yellow;
                    break;
                case 4:
                    armours = armourShop.GetItems().FindAll(item => item.ArmourType == ArmourType.Boots);
                    bootsPic.BorderStyle = BorderStyle.FixedSingle;
                    bootsPic.BackColor = Color.Yellow;
                    break;

            }

            FeedInventoryItemsListWithData();

            inventoryItems.Clear();
            inventoryItems.AddRange(armours);
                       

            resultBox.DataSource = armours.GetStringListFromInventoryList();
        }

        private void FeedInventoryItemsListWithData()
        {
            foreach (var item in armours)
            {
                inventoryItems.Add(item);
            }
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
