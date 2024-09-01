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
    public partial class EffectShopView : BasicShopView
    {

        private List<Effect> effects;

        private Effect SelectedEffect { get => (Effect)selectedInventoryItem; }

        public EffectShopView(ProgramCtx programCtx) : base(programCtx)
        {
            InitializeComponent();
            effects = ProgramCtx.GameSetup.EffectShop.GetItems();
            effects = ProgramCtx.GameSetup.EffectShop.GetItems();

            foreach (var item in effects)
            {
                inventoryItems.Add(item);   
            }

            OnBuyClick += EffectShopView_OnBuyClick;
            

            resultBox.DataSource = effects.GetStringListFromInventoryList();
        }

       

        private void EffectShopView_OnBuyClick()
        {
            try
            {
                ProgramCtx.GameSetup.EffectShop.BuyItem(ProgramCtx.SelectedCharacter, SelectedEffect);
                SuccessMessage("przedmiot zostal zakupiony");

            }
            catch (NoWeaponInInventoryException ex)
            {
                WarningMessage("musisz miec bron, aby to kupic");
            }
        }

        public override bool CheckIfSelectedItemCanBeBought()
        {
            return base.CheckIfSelectedItemCanBeBought() && 
                ProgramCtx.GameSetup.EffectShop.CanBeBoughtByPlayer(ProgramCtx.SelectedCharacter, SelectedEffect);
        }
    }
}
