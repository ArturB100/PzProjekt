namespace WinForm.views.Arena
{
    partial class FightView
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FightView));
            playerInfoTextBox = new RichTextBox();
            moveForwardBtn = new Button();
            panel1 = new Panel();
            helperTextBox = new RichTextBox();
            spellsList = new ComboBox();
            useSpellBtn = new Button();
            satisfyTheCrowdBtn = new Button();
            sleepBtn = new Button();
            weakAttackBtn = new Button();
            mediumAttackbtn = new Button();
            strongAttackBtn = new Button();
            moveBackBtn = new Button();
            turnIndicator = new Label();
            enemyInfoTextBox = new RichTextBox();
            panel2 = new Panel();
            enemyArmorBar = new ProgressBar();
            playerArmorBar = new ProgressBar();
            endFightResultsPanel = new Panel();
            exitBtn = new Button();
            enemyStaminaBar = new ProgressBar();
            enemyHpBar = new ProgressBar();
            playerStaminaBar = new ProgressBar();
            playerHpBar = new ProgressBar();
            enemyPanel = new Panel();
            enemyHeadPic = new PictureBox();
            enemyBodyPic = new PictureBox();
            playerPanel = new Panel();
            playerHeadPic = new PictureBox();
            playerBodyPic = new PictureBox();
            pictureBox1 = new PictureBox();
            logTextBox = new RichTextBox();
            menuStrip1 = new MenuStrip();
            poddajSięToolStripMenuItem = new ToolStripMenuItem();
            weakAttackBtnToolTip = new ToolTip(components);
            crowdSatisfactionTextBox = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            endFightResultsPanel.SuspendLayout();
            enemyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)enemyHeadPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemyBodyPic).BeginInit();
            playerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)playerHeadPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerBodyPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // playerInfoTextBox
            // 
            playerInfoTextBox.Location = new Point(84, 55);
            playerInfoTextBox.Name = "playerInfoTextBox";
            playerInfoTextBox.Size = new Size(287, 258);
            playerInfoTextBox.TabIndex = 0;
            playerInfoTextBox.Text = "";
            // 
            // moveForwardBtn
            // 
            moveForwardBtn.Location = new Point(292, 52);
            moveForwardBtn.Name = "moveForwardBtn";
            moveForwardBtn.Size = new Size(93, 45);
            moveForwardBtn.TabIndex = 1;
            moveForwardBtn.Text = "na przód";
            moveForwardBtn.UseVisualStyleBackColor = true;
            moveForwardBtn.Click += moveForwardBtn_Click;
            moveForwardBtn.MouseHover += moveForwardBtn_Hover;
            // 
            // panel1
            // 
            panel1.Controls.Add(helperTextBox);
            panel1.Controls.Add(spellsList);
            panel1.Controls.Add(useSpellBtn);
            panel1.Controls.Add(satisfyTheCrowdBtn);
            panel1.Controls.Add(sleepBtn);
            panel1.Controls.Add(weakAttackBtn);
            panel1.Controls.Add(mediumAttackbtn);
            panel1.Controls.Add(strongAttackBtn);
            panel1.Controls.Add(moveBackBtn);
            panel1.Controls.Add(moveForwardBtn);
            panel1.Location = new Point(14, 879);
            panel1.Name = "panel1";
            panel1.Size = new Size(1882, 140);
            panel1.TabIndex = 2;
            // 
            // helperTextBox
            // 
            helperTextBox.Location = new Point(1294, 0);
            helperTextBox.Name = "helperTextBox";
            helperTextBox.Size = new Size(476, 140);
            helperTextBox.TabIndex = 12;
            helperTextBox.Text = "";
            // 
            // spellsList
            // 
            spellsList.FormattingEnabled = true;
            spellsList.Location = new Point(1028, 52);
            spellsList.Name = "spellsList";
            spellsList.Size = new Size(182, 33);
            spellsList.TabIndex = 10;
            spellsList.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // useSpellBtn
            // 
            useSpellBtn.Location = new Point(894, 52);
            useSpellBtn.Name = "useSpellBtn";
            useSpellBtn.Size = new Size(112, 34);
            useSpellBtn.TabIndex = 9;
            useSpellBtn.Text = "użyj czaru";
            useSpellBtn.UseVisualStyleBackColor = true;
            useSpellBtn.Click += useSpellBtn_Click;
            useSpellBtn.MouseHover += useSpellBtn_Hover;
            // 
            // satisfyTheCrowdBtn
            // 
            satisfyTheCrowdBtn.Location = new Point(592, 41);
            satisfyTheCrowdBtn.Name = "satisfyTheCrowdBtn";
            satisfyTheCrowdBtn.Size = new Size(258, 57);
            satisfyTheCrowdBtn.TabIndex = 8;
            satisfyTheCrowdBtn.Text = "usatysfakcjonuj tłum";
            satisfyTheCrowdBtn.UseVisualStyleBackColor = true;
            satisfyTheCrowdBtn.Click += satisfyTheCrowdBtn_Click;
            satisfyTheCrowdBtn.MouseHover += sattisfyTheCrowdBtn_Hover;
            // 
            // sleepBtn
            // 
            sleepBtn.Location = new Point(174, 57);
            sleepBtn.Name = "sleepBtn";
            sleepBtn.Size = new Size(112, 34);
            sleepBtn.TabIndex = 7;
            sleepBtn.Text = "śpij";
            sleepBtn.UseVisualStyleBackColor = true;
            sleepBtn.Click += sleepBtn_Click;
            sleepBtn.MouseHover += sleepBtn_Hoveer;
            // 
            // weakAttackBtn
            // 
            weakAttackBtn.Location = new Point(456, 92);
            weakAttackBtn.Name = "weakAttackBtn";
            weakAttackBtn.Size = new Size(112, 34);
            weakAttackBtn.TabIndex = 6;
            weakAttackBtn.Text = "atak słaby";
            weakAttackBtn.UseVisualStyleBackColor = true;
            weakAttackBtn.Click += weakAttackBtn_Click;
            weakAttackBtn.MouseHover += weakAttackBtn_Hover;
            // 
            // mediumAttackbtn
            // 
            mediumAttackbtn.Location = new Point(456, 52);
            mediumAttackbtn.Name = "mediumAttackbtn";
            mediumAttackbtn.Size = new Size(112, 34);
            mediumAttackbtn.TabIndex = 5;
            mediumAttackbtn.Text = "atak średni";
            mediumAttackbtn.UseVisualStyleBackColor = true;
            mediumAttackbtn.Click += mediumAttackbtn_Click;
            mediumAttackbtn.MouseHover += mediumAttackBtn_Hover;
            // 
            // strongAttackBtn
            // 
            strongAttackBtn.Location = new Point(456, 12);
            strongAttackBtn.Name = "strongAttackBtn";
            strongAttackBtn.Size = new Size(112, 34);
            strongAttackBtn.TabIndex = 4;
            strongAttackBtn.Text = "atak silny";
            strongAttackBtn.UseVisualStyleBackColor = true;
            strongAttackBtn.Click += strongAttackBtn_Click;
            strongAttackBtn.MouseHover += strongAttackBtn_Hover;
            // 
            // moveBackBtn
            // 
            moveBackBtn.Location = new Point(56, 57);
            moveBackBtn.Name = "moveBackBtn";
            moveBackBtn.Size = new Size(112, 34);
            moveBackBtn.TabIndex = 3;
            moveBackBtn.Text = "do tyłu";
            moveBackBtn.UseVisualStyleBackColor = true;
            moveBackBtn.Click += moveBackBtn_Click;
            moveBackBtn.MouseHover += moveBackBtn_Hover;
            // 
            // turnIndicator
            // 
            turnIndicator.AutoSize = true;
            turnIndicator.Location = new Point(836, 39);
            turnIndicator.Name = "turnIndicator";
            turnIndicator.Size = new Size(59, 25);
            turnIndicator.TabIndex = 3;
            turnIndicator.Text = "label1";
            turnIndicator.Click += turnIndicator_Click;
            // 
            // enemyInfoTextBox
            // 
            enemyInfoTextBox.Location = new Point(1479, 55);
            enemyInfoTextBox.Name = "enemyInfoTextBox";
            enemyInfoTextBox.Size = new Size(219, 258);
            enemyInfoTextBox.TabIndex = 4;
            enemyInfoTextBox.Text = "";
            // 
            // panel2
            // 
            panel2.Controls.Add(enemyArmorBar);
            panel2.Controls.Add(playerArmorBar);
            panel2.Controls.Add(endFightResultsPanel);
            panel2.Controls.Add(enemyStaminaBar);
            panel2.Controls.Add(enemyHpBar);
            panel2.Controls.Add(playerStaminaBar);
            panel2.Controls.Add(playerHpBar);
            panel2.Controls.Add(enemyPanel);
            panel2.Controls.Add(playerPanel);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(14, 319);
            panel2.Name = "panel2";
            panel2.Size = new Size(1871, 539);
            panel2.TabIndex = 5;
            // 
            // enemyArmorBar
            // 
            enemyArmorBar.Location = new Point(1537, 121);
            enemyArmorBar.Name = "enemyArmorBar";
            enemyArmorBar.Size = new Size(150, 34);
            enemyArmorBar.TabIndex = 9;
            // 
            // playerArmorBar
            // 
            playerArmorBar.Location = new Point(73, 121);
            playerArmorBar.Name = "playerArmorBar";
            playerArmorBar.Size = new Size(150, 34);
            playerArmorBar.TabIndex = 8;
            // 
            // endFightResultsPanel
            // 
            endFightResultsPanel.Controls.Add(exitBtn);
            endFightResultsPanel.Location = new Point(492, 47);
            endFightResultsPanel.Name = "endFightResultsPanel";
            endFightResultsPanel.Size = new Size(839, 448);
            endFightResultsPanel.TabIndex = 7;
            endFightResultsPanel.Visible = false;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(357, 344);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(112, 34);
            exitBtn.TabIndex = 0;
            exitBtn.Text = "Wyjdz";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // enemyStaminaBar
            // 
            enemyStaminaBar.Location = new Point(1537, 71);
            enemyStaminaBar.Name = "enemyStaminaBar";
            enemyStaminaBar.Size = new Size(150, 34);
            enemyStaminaBar.TabIndex = 5;
            // 
            // enemyHpBar
            // 
            enemyHpBar.Location = new Point(1537, 20);
            enemyHpBar.Name = "enemyHpBar";
            enemyHpBar.Size = new Size(150, 34);
            enemyHpBar.TabIndex = 4;
            // 
            // playerStaminaBar
            // 
            playerStaminaBar.Location = new Point(73, 71);
            playerStaminaBar.Name = "playerStaminaBar";
            playerStaminaBar.Size = new Size(150, 34);
            playerStaminaBar.TabIndex = 3;
            // 
            // playerHpBar
            // 
            playerHpBar.ForeColor = Color.Red;
            playerHpBar.Location = new Point(73, 20);
            playerHpBar.Name = "playerHpBar";
            playerHpBar.Size = new Size(150, 34);
            playerHpBar.TabIndex = 2;
            // 
            // enemyPanel
            // 
            enemyPanel.Controls.Add(enemyHeadPic);
            enemyPanel.Controls.Add(enemyBodyPic);
            enemyPanel.Location = new Point(1575, 250);
            enemyPanel.Name = "enemyPanel";
            enemyPanel.Size = new Size(121, 245);
            enemyPanel.TabIndex = 1;
            // 
            // enemyHeadPic
            // 
            enemyHeadPic.Location = new Point(21, 22);
            enemyHeadPic.Name = "enemyHeadPic";
            enemyHeadPic.Size = new Size(78, 62);
            enemyHeadPic.TabIndex = 3;
            enemyHeadPic.TabStop = false;
            // 
            // enemyBodyPic
            // 
            enemyBodyPic.Image = (Image)resources.GetObject("enemyBodyPic.Image");
            enemyBodyPic.Location = new Point(3, 80);
            enemyBodyPic.Name = "enemyBodyPic";
            enemyBodyPic.Size = new Size(120, 142);
            enemyBodyPic.SizeMode = PictureBoxSizeMode.StretchImage;
            enemyBodyPic.TabIndex = 2;
            enemyBodyPic.TabStop = false;
            // 
            // playerPanel
            // 
            playerPanel.Controls.Add(playerHeadPic);
            playerPanel.Controls.Add(playerBodyPic);
            playerPanel.Location = new Point(191, 250);
            playerPanel.Name = "playerPanel";
            playerPanel.Size = new Size(126, 245);
            playerPanel.TabIndex = 0;
            // 
            // playerHeadPic
            // 
            playerHeadPic.Location = new Point(22, 22);
            playerHeadPic.Name = "playerHeadPic";
            playerHeadPic.Size = new Size(78, 62);
            playerHeadPic.SizeMode = PictureBoxSizeMode.Zoom;
            playerHeadPic.TabIndex = 1;
            playerHeadPic.TabStop = false;
            // 
            // playerBodyPic
            // 
            playerBodyPic.Image = (Image)resources.GetObject("playerBodyPic.Image");
            playerBodyPic.Location = new Point(3, 80);
            playerBodyPic.Name = "playerBodyPic";
            playerBodyPic.Size = new Size(120, 142);
            playerBodyPic.SizeMode = PictureBoxSizeMode.StretchImage;
            playerBodyPic.TabIndex = 0;
            playerBodyPic.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1897, 566);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // logTextBox
            // 
            logTextBox.Location = new Point(452, 81);
            logTextBox.Name = "logTextBox";
            logTextBox.Size = new Size(693, 232);
            logTextBox.TabIndex = 6;
            logTextBox.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { poddajSięToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1920, 33);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // poddajSięToolStripMenuItem
            // 
            poddajSięToolStripMenuItem.Name = "poddajSięToolStripMenuItem";
            poddajSięToolStripMenuItem.Size = new Size(109, 29);
            poddajSięToolStripMenuItem.Text = "Poddaj się";
            poddajSięToolStripMenuItem.Click += poddajSięToolStripMenuItem_Click;
            // 
            // crowdSatisfactionTextBox
            // 
            crowdSatisfactionTextBox.Location = new Point(1221, 81);
            crowdSatisfactionTextBox.Name = "crowdSatisfactionTextBox";
            crowdSatisfactionTextBox.Size = new Size(150, 31);
            crowdSatisfactionTextBox.TabIndex = 8;
            // 
            // FightView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(crowdSatisfactionTextBox);
            Controls.Add(logTextBox);
            Controls.Add(panel2);
            Controls.Add(enemyInfoTextBox);
            Controls.Add(turnIndicator);
            Controls.Add(panel1);
            Controls.Add(playerInfoTextBox);
            Controls.Add(menuStrip1);
            Name = "FightView";
            Size = new Size(1920, 1080);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            endFightResultsPanel.ResumeLayout(false);
            enemyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)enemyHeadPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemyBodyPic).EndInit();
            playerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)playerHeadPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerBodyPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox playerInfoTextBox;
        private Button moveForwardBtn;
        private Panel panel1;
        private Button moveBackBtn;
        private Button strongAttackBtn;
        private Button useSpellBtn;
        private Button satisfyTheCrowdBtn;
        private Button sleepBtn;
        private Button weakAttackBtn;
        private Button mediumAttackbtn;
        private Label turnIndicator;
        private RichTextBox enemyInfoTextBox;
        private Panel panel2;
        private Panel enemyPanel;
        private PictureBox enemyHeadPic;
        private PictureBox enemyBodyPic;
        private Panel playerPanel;
        private PictureBox playerHeadPic;
        private PictureBox playerBodyPic;
        private RichTextBox logTextBox;
        private ProgressBar enemyStaminaBar;
        private ProgressBar enemyHpBar;
        private ProgressBar playerStaminaBar;
        private ProgressBar playerHpBar;
        private PictureBox pictureBox1;
        private Panel endFightResultsPanel;
        private Button exitBtn;
        private ProgressBar enemyArmorBar;
        private ProgressBar playerArmorBar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem poddajSięToolStripMenuItem;
        private ComboBox spellsList;
        private ToolTip weakAttackBtnToolTip;
        private RichTextBox helperTextBox;
        private TextBox crowdSatisfactionTextBox;
    }
}
