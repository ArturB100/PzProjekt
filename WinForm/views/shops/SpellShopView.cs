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
    public partial class SpellShopView : BasicShopView
    {

        private List<Spell> spells;

        private Spell SelectedSpell { get => (Spell)selectedInventoryItem; }
        public SpellShopView(ProgramCtx programCtx) : base(programCtx)
        {
            InitializeComponent();

            spells = ProgramCtx.GameSetup.SpellShop.GetItems();

            foreach (var item in spells)
            {
                inventoryItems.Add(item);
            }

            OnBuyClick += SpellShopView_OnBuyClick;


            resultBox.DataSource = spells.GetStringListFromInventoryList();
        }

        private void SpellShopView_OnBuyClick()
        {

            ProgramCtx.GameSetup.SpellShop.BuyItem(ProgramCtx.SelectedCharacter, SelectedSpell);
            ProgramCtx.SuccessMessage("przedmiot zostal zakupiony");

        }




        public override bool CheckIfSelectedItemCanBeBought()
        {
            return base.CheckIfSelectedItemCanBeBought() &&
                ProgramCtx.GameSetup.SpellShop.CanBeBoughtByPlayer(ProgramCtx.SelectedCharacter, SelectedSpell);
        }





        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
