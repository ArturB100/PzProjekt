using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.components;

namespace WinForm.views
{
    public partial class GameSelectView : UserControlBase
    {
        List<Panel> panelList = new List<Panel>();
        List<Label> labelList = new List<Label>();

        

        public GameSelectView(Form1 form) : base(form)
        {
            InitializeComponent();
            panelList.Add(gameSelectPanel1);
            panelList.Add(gameSelectPanel2);
            panelList.Add(gameSelectPanel3);
            panelList.Add(gameSelectPanel4);
            panelList.Add(gameSelectPanel5);

            labelList.Add(label1);
            labelList.Add(label2);
            labelList.Add(label3);
            labelList.Add(label4);
            labelList.Add(label5);

            for (int i = 0; i < form.SavedGames.Count; i++)
            {
                labelList[i].Text = form.SavedGames[i];
            }

            if (form.SavedGames.Count < 5)
            {
                int timesToLoop = 5 - form.SavedGames.Count;
                for (int i = form.SavedGames.Count; i < 5; i++)
                {
                    labelList[i].Text = "Nowa gra";
                }
            }

        }

        private void gameSelectPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void woodButton1_Click(object sender, EventArgs e)
        {
            MakeAction(0);

        }

        private void woodButton2_Click(object sender, EventArgs e)
        {

        }

        private void woodButton3_Click(object sender, EventArgs e)
        {

        }

        private void woodButton4_Click(object sender, EventArgs e)
        {

        }

        private void woodButton5_Click(object sender, EventArgs e)
        {

        }

        private void MakeAction (int number)
        {
            
            if (MainForm.SavedGames.Count > number)
            {

            }
            else
            {
                MainForm.SelectedCharacter = new PzProjekt.Character();
                MainForm.ChangeView(new CreateCharacterView(MainForm));
            }

            
        }
    }
}
