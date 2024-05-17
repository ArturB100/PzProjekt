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
    public partial class SpellShopView : UserControlBase
    {

        private List<Spell> spells;

        private Spell selectedSpell;
        public SpellShopView(ProgramCtx programCtx) : base(programCtx, true)
        {
            InitializeComponent();

            spells = ProgramCtx.GameSetup.SpellShop.GetItems();
            resultBox.DataSource = spells.Select(s => s.SpellDescription()).ToList();
            spells = ProgramCtx.GameSetup.SpellShop.GetItems();

            resultBox.DataSource = spells.GetStringListFromInventoryList();


            UpdateInfoAboutCharacter();
        }

        public void UpdateInfoAboutCharacter ()
        {
            characterStatisticsBox.Text = ProgramCtx.SelectedCharacter.DisplayInformationsInShop();
        }

        private void resultBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSpell = spells[resultBox.SelectedIndex];
        }

        public bool CheckIfSelectedItemCanBeBought()
        {
            return
            (
                selectedSpell != null &&
                ProgramCtx.GameSetup.SpellShop.CanBeBoughtByPlayer(ProgramCtx.SelectedCharacter, selectedSpell)
            );


        }



        private void buyBtn_Click(object sender, EventArgs e)
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
                ProgramCtx.GameSetup.SpellShop.BuyItem(ProgramCtx.SelectedCharacter, selectedSpell);
                ProgramCtx.SuccessMessage("przedmiot zostal zakupiony");
            }

            UpdateInfoAboutCharacter();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
