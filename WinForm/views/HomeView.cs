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
    public partial class HomeView : UserControlBase
    {

        public HomeView(ProgramCtx form) : base(form, false)
        {
            InitializeComponent();
            ProgramCtx.SoundPlayer.PlayThemeSong();
            ToolStripMenuItem menuItemTemp = new ToolStripMenuItem("default");
            menuItemTemp.Click += (sender, e) =>
            {
                ProgramCtx.SelectedBotActions = null;
                selectedAiLabel.Text = "Default";
            };
            pluginsToolStripMenuItem.DropDownItems.Add(menuItemTemp);

            foreach (var item in ProgramCtx.BotActions)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(item.NameOfPlugin());
                menuItem.Click += (sender, e) =>
                {
                    ProgramCtx.SelectedBotActions = item;
                    selectedAiLabel.Text = item.NameOfPlugin();
                };
                pluginsToolStripMenuItem.DropDownItems.Add(menuItem);
            }
        }




        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgramCtx.SaveGame();
        }

        private void wyjdzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgramCtx.SaveGame();
            ProgramCtx.SelectedCharacter = null;
            ProgramCtx.ChangeView(new FirstPage(ProgramCtx));
        }

        private void weponsmithBtn_Click(object sender, EventArgs e)
        {
            ProgramCtx.ChangeView(new WeaponsmithView(ProgramCtx));
        }

        private void armouryBtn_Click(object sender, EventArgs e)
        {
            ProgramCtx.ChangeView(new ArmourShopView(ProgramCtx));
        }

        private void currentCharacterDetailsBtn_Click(object sender, EventArgs e)
        {
            ProgramCtx.ChangeView(new SelectedCharacterDetailsView(ProgramCtx));
        }

        private void magicShopBtn_Click(object sender, EventArgs e)
        {
            ProgramCtx.ChangeView(new SpellShopView(ProgramCtx));
        }

        private void EffectShopBtn_Click(object sender, EventArgs e)
        {
            ProgramCtx.ChangeView(new EffectShopView(ProgramCtx));
        }

        private void churchBtn_Click(object sender, EventArgs e)
        {
            ProgramCtx.ChangeView(new ChurchView(ProgramCtx));
        }

        private void arenaBtn_Click(object sender, EventArgs e)
        {
            ProgramCtx.ChangeView(new ArenaView(ProgramCtx));
        }

        private void pluginsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
