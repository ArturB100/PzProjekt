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

            RefreshPanels();

        }

        private void RefreshPanels ()
        {
            for (int i = 0; i < ProgramCtx.PlayableCharacters.Count; i++)
            {
                labelList[i].Text = $"{ProgramCtx.PlayableCharacters[i].Name}, Level-{ProgramCtx.PlayableCharacters[i].Parameters.Level}";
            }

            if (ProgramCtx.PlayableCharacters.Count < 5)
            {
                for (int i = ProgramCtx.PlayableCharacters.Count; i < 5; i++)
                {
                    labelList[i].Text = "Nowa gra";
                }
            }

            deleteBtn1.Visible = ProgramCtx.PlayableCharacters.Count > 0;
            deleteBtn2.Visible = ProgramCtx.PlayableCharacters.Count > 1;
            deleteBtn3.Visible = ProgramCtx.PlayableCharacters.Count > 2;
            deleteBtn4.Visible = ProgramCtx.PlayableCharacters.Count > 3;
            deleteBtn5.Visible = ProgramCtx.PlayableCharacters.Count > 4;
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

        private void MakeAction(int number)
        {

            if (ProgramCtx.PlayableCharacters.Count > number)
            {
                ProgramCtx.SelectCharacter(ProgramCtx.PlayableCharacters[number]);
                ProgramCtx.ChangeView(new HomeView(ProgramCtx));
            }
            else
            {
                ProgramCtx.SelectCharacter(new PzProjekt.Character());
                ProgramCtx.ChangeView(new CreateCharacterView(ProgramCtx));
            }


        }

        private void DeleteSavedCharacter (int index)
        {
            ProgramCtx.PlayableCharacters.Remove(index);
            RefreshPanels();
        }

        private void deleteBtn1_Click(object sender, EventArgs e)
        {
            DeleteSavedCharacter(0);
        }

        private void deleteBtn2_Click(object sender, EventArgs e)
        {
            DeleteSavedCharacter(1);
        }

        private void deleteBtn3_Click(object sender, EventArgs e)
        {
            DeleteSavedCharacter(2);
        }

        private void deleteBtn4_Click(object sender, EventArgs e)
        {
            DeleteSavedCharacter(3);
        }

        private void deleteBtn5_Click(object sender, EventArgs e)
        {
            DeleteSavedCharacter(4);
        }
    }
}
