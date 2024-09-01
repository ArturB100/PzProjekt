using PzProjekt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.views.Arena
{
    public partial class FightView : UserControlBase
    {

        private Character player;
        private Character enemy;
        private Fight fight;
        public FightView(ProgramCtx programCtx, Fight fight) : base(programCtx, false)
        {
            InitializeComponent();






            this.player = fight.Player;
            this.enemy = fight.Enemy;
            this.fight = fight;
            fight.OnPlayerTurn += Fight_OnPlayerTurn;
            fight.SetOnPlayerMove(Fight_OnPlayerMove);
            fight.SetOnEnemyMove(Fight_OnEnemyMove);
            fight.onActionDispatched += Fight_OnActionDispatched;

            Image playerImage = Image.FromFile(player.HeadImage != null ? player.HeadImage : "images/head.png");
            playerHeadPic.Image = playerImage;
            playerHeadPic.SizeMode = PictureBoxSizeMode.StretchImage;


            Image enemyImage = Image.FromFile(enemy.HeadImage != null ? enemy.HeadImage : "images/head.png");
            enemyHeadPic.Image = enemyImage;
            enemyHeadPic.SizeMode = PictureBoxSizeMode.StretchImage;

            // start screen that disappears after a couple of seconds
            new Thread(() =>
            {
                
                 PrefightScreen(playerImage, enemyImage);
               
            }).Start();

            playerPanel.Location = new Point(ConvertPositionOfCharacterToLocation(player.Parameters.Position), playerPanel.Location.Y);
            enemyPanel.Location = new Point(ConvertPositionOfCharacterToLocation(enemy.Parameters.Position), enemyPanel.Location.Y);


            // progress bars
            playerHpBar.Minimum = 0;
            playerHpBar.Maximum = player.Parameters.MaxHP;

            playerStaminaBar.Minimum = 0;
            playerStaminaBar.Maximum = player.Parameters.MaxStamina;

            playerArmorBar.Minimum = 0;
            playerArmorBar.Maximum = player.Inventory.ArmourSet.MaxArmorPoints;

            enemyHpBar.Minimum = 0;
            enemyHpBar.Maximum = enemy.Parameters.MaxHP;

            enemyStaminaBar.Minimum = 0;
            enemyStaminaBar.Maximum = enemy.Parameters.MaxStamina;

            enemyArmorBar.Minimum = 0;
            enemyArmorBar.Maximum = enemy.Inventory.ArmourSet.MaxArmorPoints;

            RefreshProgressBars();

            RefreshText();
            RefreshControlButtons();

            RefreshSpellsList();
            RefreshCrowdSatisfaction();



        }

        private void PrefightScreen(Image playerImage, Image enemyImage)
        {
            PrefightPanel.Show();
            PrefightPanel.BringToFront();
            PrefightPlayerHeadPic.Image = playerImage;
            PrefightenemyHeadPic.Image = enemyImage;
            Thread.Sleep(2000);
            HidePanel();

        }

        private void HidePanel()
        {
            if (PrefightPanel.InvokeRequired)
            {
                PrefightPanel.Invoke((MethodInvoker)delegate
                {
                    PrefightPanel.Visible = false;
                });
            }
            else
            {
                PrefightPanel.Visible = false;
            }
        }

        private int decision = 0;
        private void SetDecision(int value)
        {
            decision = value;

        }
        private int Fight_OnPlayerTurn()
        {         

            return decision;
        }

        private void Fight_OnPlayerMove(int prevPos, int actualPos)
        {
            MoveCharacterAnimation(playerPanel, prevPos, actualPos);
            //ProgramCtx.WarningMessage("player move");
        }

        private void Fight_OnEnemyMove(int prevPos, int actualPos)
        {
            MoveCharacterAnimation(enemyPanel, prevPos, actualPos);
        }

        private void Fight_OnActionDispatched(string msg)
        {
            logTextBox.Text += msg;
            logTextBox.SelectionStart = logTextBox.Text.Length;
            logTextBox.ScrollToCaret();
        }


        private void RefreshProgressBars()
        {

            playerHpBar.Value = player.Parameters.ActualHP;
            playerHpBar.Refresh();

            enemyHpBar.Value = enemy.Parameters.ActualHP;
            enemyHpBar.Refresh();

            playerStaminaBar.Value = player.Parameters.ActualStamina;
            playerStaminaBar.Refresh();

            enemyStaminaBar.Value = enemy.Parameters.ActualStamina;
            enemyStaminaBar.Refresh();

            playerArmorBar.Value = player.Inventory.ArmourSet.ActualArmorPoints;
            playerArmorBar.Refresh();

            enemyArmorBar.Value = enemy.Inventory.ArmourSet.ActualArmorPoints;
            enemyArmorBar.Refresh();
        }

        private int ConvertPositionOfCharacterToLocation(int position)
        {
            return (int)(Convert.ToDouble(position) / 1000 * 1747 + 3);
        }

        private void RefreshSpellsList()
        {
            spellsList.DataSource = null;
            spellsList.DataSource = player.Inventory.AvailableSpells;


        }

        private void NextTurn(int playerDecision)
        {
            CheckIfFightIsOver();
            if (isFightOver)
            {
                return;
            }

            Character activeCharacter = fight.ActiveCharacter;

            SetDecision(playerDecision);
            fight.NextTurn();

            if (activeCharacter == player)
            {
                RefreshPlayerText();
                RefreshProgressBars();
                RefreshControlButtons();
                RefreshEnemyText();
                // recursive call 
                NextTurn(0);
            }
            else if (activeCharacter == enemy)
            {
                //Thread.Sleep(200);
                RefreshProgressBars();
                RefreshControlButtons();
                RefreshEnemyText();
                RefreshPlayerText();
            }

            RefreshTurnIndicator();
            RefreshCrowdSatisfaction();


            decision = 0;
        }

        private void RefreshCrowdSatisfaction()
        {
            crowdSatisfactionTextBox.Text = "satysfakcja tłumu " + fight.CrowdSatisfaction.ToString();
        }


        private bool isFightOver = false;

        Result fightResult;
        private void CheckIfFightIsOver()
        {
            fightResult = fight.CheckFightResult();
            if (Result.WON == fightResult)
            {
                ProgramCtx.SuccessMessage("Congratulations, you won!");
                TakeDownCharacterHeadIfTournament(enemyHeadPic);
            }
            else if (Result.LOST == fightResult)
            {
                ProgramCtx.WarningMessage("Ooops, you lost!");
                TakeDownCharacterHeadIfTournament(playerHeadPic);
            }
            else
            {
                return;
            }
            Thread.Sleep(1000);
            isFightOver = true;
            endFightResultsPanel.Visible = true;
            fightResultsTextBox.Text = fight.EndFight(fightResult);
        }


        private void TakeDownCharacterHeadIfTournament(PictureBox pictureBox)
        {
            if (ProgramCtx.ActiveTournament != null)
            {
                TakeDownCharacterHead(pictureBox);
            }
        }


        private void TakeDownCharacterHead(PictureBox pictureBox)
        {
            DistanceTwoCharactersFromEachOther();
            int iteratorCounter = 10;
            pictureBox.Image = RotateImageBy90Degrees(pictureBox.Image);

            for (int i = 0; i < iteratorCounter; i++)
            {
                pictureBox.Location = new System.Drawing.Point(pictureBox.Location.X, pictureBox.Location.Y + (138 / iteratorCounter));
                pictureBox.BringToFront();
                this.Refresh();
                Thread.Sleep(1000 / iteratorCounter);
            }
            this.Refresh();

        }

        public void DistanceTwoCharactersFromEachOther()
        {

            if (player.Parameters.Position < 100 || player.Parameters.Position > 900 || 
                enemy.Parameters.Position < 100 || enemy.Parameters.Position > 900
               )
            {
                int distanceFromEachOther = 100;
                playerPanel.Location = new System.Drawing.Point(
                        player.Parameters.Position < enemy.Parameters.Position ? 500 - distanceFromEachOther : 500 + distanceFromEachOther, 
                        playerPanel.Location.Y);

                enemyPanel.Location = new System.Drawing.Point(
                        player.Parameters.Position > enemy.Parameters.Position ? 500 - distanceFromEachOther : 500 + distanceFromEachOther,
                        enemyPanel.Location.Y);
            } 
            else
            {
                int distanceToMove = 140;
                if (player.Parameters.Position < enemy.Parameters.Position)
                {
                    distanceToMove = -distanceToMove;
                }
                playerPanel.Location = new System.Drawing.Point(playerPanel.Location.X + distanceToMove, playerPanel.Location.Y);
                enemyPanel.Location = new System.Drawing.Point(enemyPanel.Location.X - distanceToMove, enemyPanel.Location.Y);
            }

            this.Refresh();



        }

        private Image RotateImageBy90Degrees(Image img)
        {
            Bitmap rotatedBmp = new Bitmap(img.Height, img.Width);

            Graphics g = Graphics.FromImage(rotatedBmp);

            g.TranslateTransform((float)rotatedBmp.Width / 2, (float)rotatedBmp.Height / 2);

            g.RotateTransform(90);

            g.TranslateTransform(-(float)img.Width / 2, -(float)img.Height / 2);

            g.DrawImage(img, new Point(0, 0));

            return rotatedBmp;
        }
        private void nextRoundBtn_Click(object sender, EventArgs e)
        {
            //
        }



        private void MoveCharacterAnimation(Panel panel, int prevPos, int actualPos)
        {
            prevPos = ConvertPositionOfCharacterToLocation(prevPos);
            actualPos = ConvertPositionOfCharacterToLocation(actualPos);

            int step = actualPos > prevPos ?
                (actualPos - prevPos) / 10
                :
                -Math.Abs(actualPos - prevPos) / 10;


            for (int i = 0; i < 10; i++)
            {
                panel.Location = new Point(
                   panel.Location.X + step,
                   panel.Location.Y
                );

                Thread.Sleep(10);
            }
            this.Refresh();
        }




        private void turnIndicator_Click(object sender, EventArgs e)
        {

        }

        private void RefreshControlButtons()
        {
            strongAttackBtn.BackColor = fight.CharacterFightActions.IsAttackPossible(AttackType.STRONG) ? Color.Transparent : Color.Red;
            mediumAttackbtn.BackColor = fight.CharacterFightActions.IsAttackPossible(AttackType.MEDIUM) ? Color.Transparent : Color.Red;
            weakAttackBtn.BackColor = fight.CharacterFightActions.IsAttackPossible(AttackType.WEAK) ? Color.Transparent : Color.Red;


            int stamina = player.Parameters.ActualStamina;
            bool movePossible = stamina > 20;
            moveForwardBtn.BackColor = movePossible ? Color.Transparent : Color.Red;
            moveBackBtn.BackColor = movePossible ? Color.Transparent : Color.Red;

        }

        private void RefreshPlayerText()
        {
            playerInfoTextBox.Text = $"ja {player.DisplayInformationInFight()}";
            playerInfoTextBox.Refresh();
        }

        private void RefreshEnemyText()
        {
            enemyInfoTextBox.Text = $"przeciwnik: {enemy.DisplayInformationInFight()}";
            enemyInfoTextBox.Refresh();
        }

        private void RefreshTurnIndicator()
        {
            turnIndicator.Text = fight.ActiveCharacter == player ? "Twoja tura" : "Tura przeciwnika";
            turnIndicator.Refresh();
        }
        private void RefreshText()
        {
            playerInfoTextBox.Text = $"ja {player.DisplayInformationInFight()}  \n";

            enemyInfoTextBox.Text = $"przeciwnik: {enemy.DisplayInformationInFight()}";

        }

        private void moveForwardBtn_Click(object sender, EventArgs e)
        {
            if (player.Parameters.ActualStamina > 20)
            {
                NextTurn(4);
            }
            else
            {
                DisplayOperationImpossible();
            }

        }

        private void moveBackBtn_Click(object sender, EventArgs e)
        {
            if (player.Parameters.ActualStamina > 20)
            {
                NextTurn(5);
            }
            else
            {
                DisplayOperationImpossible();
            }
        }

        private void sleepBtn_Click(object sender, EventArgs e)
        {
            NextTurn(6);
        }

        private void strongAttackBtn_Click(object sender, EventArgs e)
        {
            if (fight.CharacterFightActions.IsAttackPossible(AttackType.STRONG))
                NextTurn(1);
            else
                DisplayOperationImpossible();
        }

        private void DisplayOperationImpossible()
        {
            ProgramCtx.WarningMessage("Operacja nie mozliwa");
        }

        private void mediumAttackbtn_Click(object sender, EventArgs e)
        {
            if (fight.CharacterFightActions.IsAttackPossible(AttackType.MEDIUM))
                NextTurn(2);
            else
                DisplayOperationImpossible();
        }

        private void weakAttackBtn_Click(object sender, EventArgs e)
        {
            if (fight.CharacterFightActions.IsAttackPossible(AttackType.WEAK))
                NextTurn(3);
            else
                DisplayOperationImpossible();
        }

        private void satisfyTheCrowdBtn_Click(object sender, EventArgs e)
        {
            NextTurn(7);
        }

        private void useSpellBtn_Click(object sender, EventArgs e)
        {
            if (player.Inventory.SelectedSpell == null)
            {
                ProgramCtx.WarningMessage("najpierw musisz wybrac czar");
            }
            else
            {
                NextTurn(8);
                RefreshSpellsList();
                player.Inventory.SelectedSpell = null;
            }

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (ProgramCtx.ActiveTournament == null)
            {
                ProgramCtx.ChangeView(new HomeView(ProgramCtx));
            }
            else
            {
                if (fightResult == Result.WON)
                {
                    ProgramCtx.ChangeView(new TournamentView(ProgramCtx));
                }
                else if (fightResult == Result.LOST)
                {
                    ProgramCtx.ChangeView(new FirstPage(ProgramCtx));
                    ProgramCtx.SelectedCharacter = null;
                }

            }
        }

        private void poddajSięToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isFightOver = true;
            endFightResultsPanel.Visible = true;
            fightResult = Result.LOST;
            fightResultsTextBox.Text = fight.EndFight(Result.LOST);
            ProgramCtx.ActiveTournament = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = spellsList.SelectedIndex;
            if (player.Inventory.AvailableSpells.Count <= index)
            {
                ProgramCtx.WarningMessage("Nie ma takiego czaru");
                RefreshSpellsList();
            }
            else
            {
                player.Inventory.SelectedSpell = player.Inventory.AvailableSpells[index];

            }

        }

        private void weakAttackBtn_Hover(object sender, EventArgs e)
        {
            helperTextBox.Text = $"szansa trafienia: {fight.CharacterFightActions.GetAttackChanceToHit(AttackType.WEAK)} \n" +
                $"czy atak możliwy: {fight.CharacterFightActions.IsAttackPossible(AttackType.WEAK)} \n";

        }

        private void mediumAttackBtn_Hover(object sender, EventArgs e)
        {
            helperTextBox.Text = $"szansa trafienia: {fight.CharacterFightActions.GetAttackChanceToHit(AttackType.MEDIUM)}";
        }

        private void strongAttackBtn_Hover(object sender, EventArgs e)
        {
            helperTextBox.Text = $"szansa trafienia: {fight.CharacterFightActions.GetAttackChanceToHit(AttackType.STRONG)}";
        }

        private void moveForwardBtn_Hover(object sender, EventArgs e)
        {
            helperTextBox.Text = "potrzebna stamina: 20";
        }

        private void sleepBtn_Hoveer(object sender, EventArgs e)
        {

        }

        private void moveBackBtn_Hover(object sender, EventArgs e)
        {

        }

        private void sattisfyTheCrowdBtn_Hover(object sender, EventArgs e)
        {

        }

        private void useSpellBtn_Hover(object sender, EventArgs e)
        {

        }

        private void crowdSatisfactionTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
