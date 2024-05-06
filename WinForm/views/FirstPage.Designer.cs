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
            continueBtn = new Button();
            backgroundImg = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)backgroundImg).BeginInit();
            SuspendLayout();
            // 
            // newGameBtn
            // 
            newGameBtn.Location = new Point(1181, 703);
            newGameBtn.Name = "newGameBtn";
            newGameBtn.Size = new Size(112, 34);
            newGameBtn.TabIndex = 0;
            newGameBtn.Text = "Nowa Gra";
            newGameBtn.UseVisualStyleBackColor = true;
            newGameBtn.Click += button1_Click;
            // 
            // continueBtn
            // 
            continueBtn.Location = new Point(1181, 793);
            continueBtn.Name = "continueBtn";
            continueBtn.Size = new Size(112, 34);
            continueBtn.TabIndex = 1;
            continueBtn.Text = "kontynuj";
            continueBtn.UseVisualStyleBackColor = true;
            // 
            // backgroundImg
            // 
            backgroundImg.Image = (Image)resources.GetObject("backgroundImg.Image");
            backgroundImg.Location = new Point(3, 3);
            backgroundImg.Name = "backgroundImg";
            backgroundImg.Size = new Size(2523, 1484);
            backgroundImg.SizeMode = PictureBoxSizeMode.StretchImage;
            backgroundImg.TabIndex = 2;
            backgroundImg.TabStop = false;
            backgroundImg.Click += pictureBox1_Click;
            // 
            // FirstPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(continueBtn);
            Controls.Add(newGameBtn);
            Controls.Add(backgroundImg);
            Name = "FirstPage";
            Size = new Size(2540, 1490);
            Load += FirstPage_Load;
            ((System.ComponentModel.ISupportInitialize)backgroundImg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button newGameBtn;
        private Button continueBtn;
        private PictureBox backgroundImg;
    }
}
