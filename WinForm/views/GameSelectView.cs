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

        

        public GameSelectView(ProgramCtx form) : base(form)
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

            for (int i = 0; i < form.PlayableCharacters.Count; i++)
            {
                labelList[i].Text = $"{form.PlayableCharacters[i].Name}, Level-{form.PlayableCharacters[i].Parameters.Level}";
            }

            if (form.PlayableCharacters.Count < 5)
            {
                int timesToLoop = 5 - form.PlayableCharacters.Count;
                for (int i = form.PlayableCharacters.Count; i < 5; i++)
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
            MakeAction(1);
        }

        private void woodButton3_Click(object sender, EventArgs e)
        {
            MakeAction(2);
        }

        private void woodButton4_Click(object sender, EventArgs e)
        {
            MakeAction(3);
        }

        private void woodButton5_Click(object sender, EventArgs e)
        {
            MakeAction(4);
        }

        private void MakeAction (int number)
        {
            
            if (ProgramCtx.PlayableCharacters.Count > number)
            {
                ProgramCtx.SelectCharacter(ProgramCtx.PlayableCharacters[number]);
                ProgramCtx.ChangeView(new HomeView(ProgramCtx));
            }
            else
            {
                ProgramCtx.SelectCharacter (new PzProjekt.Character());
                ProgramCtx.ChangeView(new CreateCharacterView(ProgramCtx));
            }

            
        }
    }
}
