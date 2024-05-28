namespace WinForm.views
{
    partial class ArenaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArenaView));
            pictureBox1 = new PictureBox();
            trainingFightBtn = new Button();
            tournamentFightBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1914, 1074);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // trainingFightBtn
            // 
            trainingFightBtn.Location = new Point(362, 284);
            trainingFightBtn.Name = "trainingFightBtn";
            trainingFightBtn.Size = new Size(399, 134);
            trainingFightBtn.TabIndex = 3;
            trainingFightBtn.Text = "Walka do pierwszej krwi";
            trainingFightBtn.UseVisualStyleBackColor = true;
            trainingFightBtn.Click += trainingFightBtn_Click_1;
            // 
            // tournamentFightBtn
            // 
            tournamentFightBtn.Location = new Point(1045, 284);
            tournamentFightBtn.Name = "tournamentFightBtn";
            tournamentFightBtn.Size = new Size(429, 137);
            tournamentFightBtn.TabIndex = 4;
            tournamentFightBtn.Text = "turniej";
            tournamentFightBtn.UseVisualStyleBackColor = true;
            tournamentFightBtn.Click += tournamentFightBtn_Click;
            // 
            // ArenaView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tournamentFightBtn);
            Controls.Add(trainingFightBtn);
            Controls.Add(pictureBox1);
            Name = "ArenaView";
            Size = new Size(1920, 1080);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Button trainingFightBtn;
        private Button tournamentFightBtn;
    }
}
