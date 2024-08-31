namespace WinForm.views
{
    partial class HomeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeView));
            pictureBox1 = new PictureBox();
            magicShopBtn = new Button();
            WeaponSmithBtn = new Button();
            churchBtn = new Button();
            armouryBtn = new Button();
            arenaBtn = new Button();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            zapiszToolStripMenuItem = new ToolStripMenuItem();
            wyjdzToolStripMenuItem = new ToolStripMenuItem();
            currentCharacterDetailsBtn = new Button();
            EffectShopBtn = new Button();
            pluginsToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-6, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1923, 1044);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // magicShopBtn
            // 
            magicShopBtn.Location = new Point(428, 585);
            magicShopBtn.Name = "magicShopBtn";
            magicShopBtn.Size = new Size(255, 53);
            magicShopBtn.TabIndex = 1;
            magicShopBtn.Text = "magic shop";
            magicShopBtn.UseVisualStyleBackColor = true;
            magicShopBtn.Click += magicShopBtn_Click;
            // 
            // WeaponSmithBtn
            // 
            WeaponSmithBtn.Location = new Point(73, 644);
            WeaponSmithBtn.Name = "WeaponSmithBtn";
            WeaponSmithBtn.Size = new Size(299, 50);
            WeaponSmithBtn.TabIndex = 2;
            WeaponSmithBtn.Text = "weaponsmith";
            WeaponSmithBtn.UseVisualStyleBackColor = true;
            WeaponSmithBtn.Click += weponsmithBtn_Click;
            // 
            // churchBtn
            // 
            churchBtn.Location = new Point(1351, 565);
            churchBtn.Name = "churchBtn";
            churchBtn.Size = new Size(171, 41);
            churchBtn.TabIndex = 3;
            churchBtn.Text = "church";
            churchBtn.UseVisualStyleBackColor = true;
            churchBtn.Click += churchBtn_Click;
            // 
            // armouryBtn
            // 
            armouryBtn.Location = new Point(1582, 793);
            armouryBtn.Name = "armouryBtn";
            armouryBtn.Size = new Size(204, 49);
            armouryBtn.TabIndex = 4;
            armouryBtn.Text = "armoury";
            armouryBtn.UseVisualStyleBackColor = true;
            armouryBtn.Click += armouryBtn_Click;
            // 
            // arenaBtn
            // 
            arenaBtn.Location = new Point(198, 178);
            arenaBtn.Name = "arenaBtn";
            arenaBtn.Size = new Size(356, 55);
            arenaBtn.TabIndex = 5;
            arenaBtn.Text = "arena";
            arenaBtn.UseVisualStyleBackColor = true;
            arenaBtn.Click += arenaBtn_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, pluginsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1920, 33);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zapiszToolStripMenuItem, wyjdzToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(73, 29);
            menuToolStripMenuItem.Text = "menu";
            // 
            // zapiszToolStripMenuItem
            // 
            zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            zapiszToolStripMenuItem.Size = new Size(270, 34);
            zapiszToolStripMenuItem.Text = "zapisz";
            zapiszToolStripMenuItem.Click += zapiszToolStripMenuItem_Click;
            // 
            // wyjdzToolStripMenuItem
            // 
            wyjdzToolStripMenuItem.Name = "wyjdzToolStripMenuItem";
            wyjdzToolStripMenuItem.Size = new Size(270, 34);
            wyjdzToolStripMenuItem.Text = "wyjdz";
            wyjdzToolStripMenuItem.Click += wyjdzToolStripMenuItem_Click;
            // 
            // currentCharacterDetailsBtn
            // 
            currentCharacterDetailsBtn.Location = new Point(1301, 102);
            currentCharacterDetailsBtn.Name = "currentCharacterDetailsBtn";
            currentCharacterDetailsBtn.Size = new Size(221, 44);
            currentCharacterDetailsBtn.TabIndex = 7;
            currentCharacterDetailsBtn.Text = "Moja postac";
            currentCharacterDetailsBtn.UseVisualStyleBackColor = true;
            currentCharacterDetailsBtn.Click += currentCharacterDetailsBtn_Click;
            // 
            // EffectShopBtn
            // 
            EffectShopBtn.Location = new Point(1141, 486);
            EffectShopBtn.Name = "EffectShopBtn";
            EffectShopBtn.Size = new Size(197, 35);
            EffectShopBtn.TabIndex = 8;
            EffectShopBtn.Text = "effects shop";
            EffectShopBtn.UseVisualStyleBackColor = true;
            EffectShopBtn.Click += EffectShopBtn_Click;
            // 
            // pluginsToolStripMenuItem
            // 
            pluginsToolStripMenuItem.Name = "pluginsToolStripMenuItem";
            pluginsToolStripMenuItem.Size = new Size(85, 29);
            pluginsToolStripMenuItem.Text = "Plugins";
            // 
            // HomeView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EffectShopBtn);
            Controls.Add(currentCharacterDetailsBtn);
            Controls.Add(arenaBtn);
            Controls.Add(armouryBtn);
            Controls.Add(churchBtn);
            Controls.Add(WeaponSmithBtn);
            Controls.Add(magicShopBtn);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Name = "HomeView";
            Size = new Size(1920, 1080);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button magicShopBtn;
        private Button WeaponSmithBtn;
        private Button churchBtn;
        private Button armouryBtn;
        private Button arenaBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem zapiszToolStripMenuItem;
        private ToolStripMenuItem wyjdzToolStripMenuItem;
        private Button currentCharacterDetailsBtn;
        private Button EffectShopBtn;
        private ToolStripMenuItem pluginsToolStripMenuItem;
    }
}
