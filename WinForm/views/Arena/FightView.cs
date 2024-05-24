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


            playerPanel.Location = new Point((int)(Convert.ToDouble(player.Parameters.Position) / 1000 * 1747 + 3), playerPanel.Location.Y);
            enemyPanel.Location = new Point((int)(Convert.ToDouble(enemy.Parameters.Position) / 1000 * 1747 + 3), enemyPanel.Location.Y);


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

            // test
            logTextBox.Text = player.Parameters.AttackRange.ToString() ;
        }

        private int decision = 0;
        private void SetDecision(int value)
        {
            decision = value;

        }
        private int Fight_OnPlayerTurn()
        {

            while (decision == 0)
            {
                //Thread.Sleep(100);
            }

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

                // recursive call 
                NextTurn(0);
            } 
            else if (activeCharacter == enemy)
            {
                //Thread.Sleep(200);
                RefreshProgressBars();
                RefreshControlButtons();
                RefreshEnemyText();
            }

            RefreshTurnIndicator();


            decision = 0;
        }

        /*private void NextTurn(int playerDecision)
        {
            CheckIfFightIsOver();
            if (isFightOver)
            {
                return;
            }
            SetDecision(playerDecision);


            fight.NextTurn();
            RefreshPlayerText();
            RefreshProgressBars();
            Thread.Sleep(1000);
            if (fight.ActiveCharacter == enemy)
            {
                fight.NextTurn();
                RefreshEnemyText();
                RefreshProgressBars();
            }

            RefreshControlButtons();

            decision = 0;
        }*/

        private bool isFightOver = false;
        private void CheckIfFightIsOver()
        {
            Result result = fight.CheckFightResult();
            if (Result.WON == result)
            {
                ProgramCtx.SuccessMessage("Congratulations, you won!");
            }
            else if (Result.LOST == result)
            {
                ProgramCtx.WarningMessage("Ooops, you lost!");
            }
            else
            {
                return;
            }

            isFightOver = true;
            endFightResultsPanel.Visible = true;
            fight.EndFight(result);
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
            strongAttackBtn.Enabled = fight.CharacterFightActions.IsAttackPossible(AttackType.STRONG);
            mediumAttackbtn.Enabled = fight.CharacterFightActions.IsAttackPossible(AttackType.MEDIUM); ;
            weakAttackBtn.Enabled = fight.CharacterFightActions.IsAttackPossible(AttackType.WEAK); ;

            int stamina = player.Parameters.ActualStamina;
            bool movePossible = stamina > 20;
            moveForwardBtn.Enabled = movePossible;
            moveBackBtn.Enabled = movePossible;

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
            NextTurn(4);
        }

        private void moveBackBtn_Click(object sender, EventArgs e)
        {
            NextTurn(5);
        }

        private void sleepBtn_Click(object sender, EventArgs e)
        {
            NextTurn(6);
        }

        private void strongAttackBtn_Click(object sender, EventArgs e)
        {
            NextTurn(1);
        }

        private void mediumAttackbtn_Click(object sender, EventArgs e)
        {
            NextTurn(2);
        }

        private void weakAttackBtn_Click(object sender, EventArgs e)
        {
            NextTurn(3);
        }

        private void satisfyTheCrowdBtn_Click(object sender, EventArgs e)
        {
            NextTurn(7);
        }

        private void useSpellBtn_Click(object sender, EventArgs e)
        {
            NextTurn(8);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (ProgramCtx.ActiveTournament == null)
            {
                ProgramCtx.ChangeView(new HomeView(ProgramCtx));
            }
            else
            {
                // TODO
            }
        }

        private void poddajSięToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isFightOver = true;
            endFightResultsPanel.Visible = true;
            fight.EndFight(Result.LOST);
        }
    }
}
