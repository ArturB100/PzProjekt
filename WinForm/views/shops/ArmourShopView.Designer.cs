namespace WinForm.views.shops
{
    partial class ArmourShopView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArmourShopView));
            resultsBox = new ListBox();
            buyBtn = new components.WoodButton();
            menuStrip1 = new MenuStrip();
            ekranGlownyToolStripMenuItem = new ToolStripMenuItem();
            helmetsPic = new PictureBox();
            chestplatePic = new PictureBox();
            leggingsPic = new PictureBox();
            bootsPic = new PictureBox();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)helmetsPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chestplatePic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leggingsPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bootsPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // resultsBox
            // 
            resultsBox.FormattingEnabled = true;
            resultsBox.ItemHeight = 25;
            resultsBox.Location = new Point(208, 478);
            resultsBox.Name = "resultsBox";
            resultsBox.Size = new Size(1370, 404);
            resultsBox.TabIndex = 0;
            resultsBox.SelectedIndexChanged += resultsBox_SelectedIndexChanged;
            // 
            // buyBtn
            // 
            buyBtn.BackColor = Color.SaddleBrown;
            buyBtn.FlatAppearance.BorderSize = 0;
            buyBtn.FlatStyle = FlatStyle.Flat;
            buyBtn.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buyBtn.ForeColor = Color.White;
            buyBtn.Location = new Point(1432, 942);
            buyBtn.Name = "buyBtn";
            buyBtn.Size = new Size(112, 34);
            buyBtn.TabIndex = 1;
            buyBtn.Text = "Kup";
            buyBtn.UseVisualStyleBackColor = false;
            buyBtn.Click += buyBtn_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ekranGlownyToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1920, 33);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // ekranGlownyToolStripMenuItem
            // 
            ekranGlownyToolStripMenuItem.Name = "ekranGlownyToolStripMenuItem";
            ekranGlownyToolStripMenuItem.Size = new Size(134, 29);
            ekranGlownyToolStripMenuItem.Text = "Ekran glowny";
            ekranGlownyToolStripMenuItem.Click += ekranGlownyToolStripMenuItem_Click;
            // 
            // helmetsPic
            // 
            helmetsPic.Image = (Image)resources.GetObject("helmetsPic.Image");
            helmetsPic.Location = new Point(164, 208);
            helmetsPic.Name = "helmetsPic";
            helmetsPic.Size = new Size(332, 180);
            helmetsPic.SizeMode = PictureBoxSizeMode.Zoom;
            helmetsPic.TabIndex = 3;
            helmetsPic.TabStop = false;
            helmetsPic.Click += pictureBox1_Click;
            // 
            // chestplatePic
            // 
            chestplatePic.Image = (Image)resources.GetObject("chestplatePic.Image");
            chestplatePic.Location = new Point(529, 208);
            chestplatePic.Name = "chestplatePic";
            chestplatePic.Size = new Size(332, 180);
            chestplatePic.SizeMode = PictureBoxSizeMode.Zoom;
            chestplatePic.TabIndex = 4;
            chestplatePic.TabStop = false;
            chestplatePic.Click += chestplatePic_Click;
            // 
            // leggingsPic
            // 
            leggingsPic.Image = (Image)resources.GetObject("leggingsPic.Image");
            leggingsPic.Location = new Point(895, 208);
            leggingsPic.Name = "leggingsPic";
            leggingsPic.Size = new Size(332, 180);
            leggingsPic.SizeMode = PictureBoxSizeMode.Zoom;
            leggingsPic.TabIndex = 5;
            leggingsPic.TabStop = false;
            leggingsPic.Click += leggingsPic_Click;
            // 
            // bootsPic
            // 
            bootsPic.Image = (Image)resources.GetObject("bootsPic.Image");
            bootsPic.Location = new Point(1295, 208);
            bootsPic.Name = "bootsPic";
            bootsPic.Size = new Size(332, 180);
            bootsPic.SizeMode = PictureBoxSizeMode.Zoom;
            bootsPic.TabIndex = 6;
            bootsPic.TabStop = false;
            bootsPic.Click += bootsPic_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1914, 1041);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // ArmourShopView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bootsPic);
            Controls.Add(leggingsPic);
            Controls.Add(chestplatePic);
            Controls.Add(helmetsPic);
            Controls.Add(buyBtn);
            Controls.Add(resultsBox);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            Name = "ArmourShopView";
            Size = new Size(1920, 1080);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)helmetsPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)chestplatePic).EndInit();
            ((System.ComponentModel.ISupportInitialize)leggingsPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)bootsPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox resultsBox;
        private components.WoodButton buyBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ekranGlownyToolStripMenuItem;
        private PictureBox helmetsPic;
        private PictureBox chestplatePic;
        private PictureBox leggingsPic;
        private PictureBox bootsPic;
        private PictureBox pictureBox1;
    }
}
