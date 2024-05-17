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
    public partial class WeaponsmithView : UserControlBase
    {



        private List<Weapon> weapons;

        private Weapon selectedWeapon;



        public WeaponsmithView(ProgramCtx form) : base(form, true)

        {
            InitializeComponent();
            resultBox.Visible = false;
            weapons = ProgramCtx.GameSetup.WeaponShop.GetItems();

            characterStatistics.Visible = false;
            characterStatistics.Text = ProgramCtx.SelectedCharacter.DisplayInformationsInShop();
            DeleteAllBordersFromPictures();
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

            characterStatistics.Visible = true;

            resultBox.Visible = true;
            resultBox.DataSource = weapons.GetItemsAsString();
        }

        private void resultBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = resultBox.SelectedIndex;
            selectedWeapon = weapons[selectedIndex];
        }

        public bool CheckIfSelectedItemCanBeBought()
        {
            return
            (
                selectedWeapon != null &&
                ProgramCtx.GameSetup.WeaponShop.CanBeBoughtByPlayer(ProgramCtx.SelectedCharacter, selectedWeapon)
            );
        }


        
        private void buyBtn_Click_1(object sender, EventArgs e)
        {

            bool canBeBuy = false;

            try
            {
                canBeBuy = CheckIfSelectedItemCanBeBought();
            } 
            catch (NoEnoughMoneyException ex)
            {
                ProgramCtx.ErrorMessage(Error.NOT_ENOUGHT_MONEY);
            } 
            catch (TooWeakLevelException ex)
            {
                ProgramCtx.ErrorMessage(Error.TOO_WEAK_LEVEL);
            }
            catch (TooWeakStatisticsException)
            {
                ProgramCtx.ErrorMessage(Error.TOO_WEAK_STATISTICS);
            }


            if (canBeBuy)
            {
                ProgramCtx.GameSetup.WeaponShop.BuyItem(ProgramCtx.SelectedCharacter, selectedWeapon);
                ProgramCtx.SuccessMessage("przedmiot zostal zakupiony");
            }
            
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
