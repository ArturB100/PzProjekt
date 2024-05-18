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

    public delegate void OnBuyClick ();
    public delegate void OnItemSelect();
    public partial class BasicShopView : UserControlBase 
    {
        public event OnBuyClick OnBuyClick;

        protected ListBox resultBox;
        protected InventoryItem selectedInventoryItem;

        protected List<InventoryItem> inventoryItems = new List<InventoryItem>() ;

        public BasicShopView(ProgramCtx programCtx) : base(programCtx, true)
        {
            InitializeComponent();

            resultBox = listBox;
            UpdateCharacterStatisticsTextBox();
        }

        protected void UpdateCharacterStatisticsTextBox()
        {
            characterStatisticsBox.Text = ProgramCtx.SelectedCharacter.DisplayInformationsInShop();
        }

        public BasicShopView() { }


        public virtual bool CheckIfSelectedItemCanBeBought()
        {
            return
            (
                selectedInventoryItem != null 
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
                OnBuyClick?.Invoke();
            }

            UpdateCharacterStatisticsTextBox();


            
        }

        private void resultBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedInventoryItem = inventoryItems[resultBox.SelectedIndex];
            
        }


     



      
    }
}
