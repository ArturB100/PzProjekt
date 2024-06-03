namespace WinForm
{
    partial class FirstPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstPage));
            newGameBtn = new Button();
            backgroundImg = new PictureBox();
            gameTitleLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)backgroundImg).BeginInit();
            SuspendLayout();
            // 
            // newGameBtn
            // 
            newGameBtn.BackColor = SystemColors.ControlLight;
            newGameBtn.Font = new Font("Segoe Print", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            newGameBtn.Location = new Point(793, 669);
            newGameBtn.Name = "newGameBtn";
            newGameBtn.Size = new Size(330, 101);
            newGameBtn.TabIndex = 0;
            newGameBtn.Text = "Graj";
            newGameBtn.UseVisualStyleBackColor = false;
            newGameBtn.Click += button1_Click;
            // 
            // backgroundImg
            // 
            backgroundImg.Image = (Image)resources.GetObject("backgroundImg.Image");
            backgroundImg.Location = new Point(0, 3);
            backgroundImg.Name = "backgroundImg";
            backgroundImg.Size = new Size(1917, 1077);
            backgroundImg.SizeMode = PictureBoxSizeMode.StretchImage;
            backgroundImg.TabIndex = 2;
            backgroundImg.TabStop = false;
            backgroundImg.Click += pictureBox1_Click;
            // 
            // gameTitleLabel
            // 
            gameTitleLabel.AutoSize = true;
            gameTitleLabel.BackColor = SystemColors.WindowText;
            gameTitleLabel.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            gameTitleLabel.ForeColor = SystemColors.ControlLightLight;
            gameTitleLabel.Location = new Point(719, 132);
            gameTitleLabel.Name = "gameTitleLabel";
            gameTitleLabel.Size = new Size(497, 96);
            gameTitleLabel.TabIndex = 3;
            gameTitleLabel.Text = "Pałki i Klapki";
            // 
            // FirstPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gameTitleLabel);
            Controls.Add(newGameBtn);
            Controls.Add(backgroundImg);
            Name = "FirstPage";
            Size = new Size(1920, 1080);
            Load += FirstPage_Load;
            ((System.ComponentModel.ISupportInitialize)backgroundImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button newGameBtn;
        private PictureBox backgroundImg;
        private Label gameTitleLabel;
    }
}
