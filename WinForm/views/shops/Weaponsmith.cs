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
using WinForm.views.shops;

namespace WinForm.views
{
    public partial class WeaponsmithView : BasicShopView
    {



        private List<Weapon> weapons;

        

        private Weapon selectedWeapon { get => (Weapon)selectedInventoryItem; }


        public WeaponsmithView(ProgramCtx form) : base(form)
        {
            InitializeComponent();
            resultBox.Visible = false;
            weapons = ProgramCtx.GameSetup.WeaponShop.GetItems();

            OnBuyClick += WeaponsmithView_OnBuyClick;




            DeleteAllBordersFromPictures();
        }

        private void WeaponsmithView_OnBuyClick()
        {
            ProgramCtx.GameSetup.WeaponShop.BuyItem(ProgramCtx.SelectedCharacter, selectedWeapon);
            ProgramCtx.SuccessMessage("przedmiot zostal zakupiony");
        }

        private void swordPic_Click(object sender, EventArgs e)
        {
            FilterData(WeaponType.Sword);
            swordPic.BorderStyle = BorderStyle.FixedSingle;
            swordPic.BackColor = Color.Yellow;
        }

        private void axePic_Click(object sender, EventArgs e)
        {
            FilterData(WeaponType.Axe);
            axePic.BorderStyle = BorderStyle.FixedSingle;
            axePic.BackColor = Color.Yellow;
        }

        private void FilterData(WeaponType weaponType)
        {
            DeleteAllBordersFromPictures();
            weapons = ProgramCtx.GameSetup.WeaponShop.GetItems().FindAll(w => w.WeaponType == weaponType);

            inventoryItems.Clear();
            inventoryItems.AddRange(weapons);

            FeedInventoryItemsListWithData();

            resultBox.Visible = true;
            resultBox.DataSource = weapons.GetStringListFromInventoryList();
        }

        private void FeedInventoryItemsListWithData ()
        {
            foreach (var item in weapons)
            {
                inventoryItems.Add(item);
            }
        }

      

        public override bool CheckIfSelectedItemCanBeBought()
        {
            return
            (
                base.CheckIfSelectedItemCanBeBought() &&
                ProgramCtx.GameSetup.WeaponShop.CanBeBoughtByPlayer(ProgramCtx.SelectedCharacter, selectedWeapon)
            );
        }


        
        


        private void DeleteAllBordersFromPictures()
        {
            swordPic.BorderStyle = BorderStyle.None;
            axePic.BorderStyle = BorderStyle.None;


            swordPic.BackColor = Color.Transparent;
            axePic.BackColor = Color.Transparent;


        }
    }
}
