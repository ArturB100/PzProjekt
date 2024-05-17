namespace WinForm.views.shops
{
    partial class SpellShopView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpellShopView));
            resultBox = new ListBox();
            buyBtn = new components.WoodButton();
            pictureBox1 = new PictureBox();
            characterStatisticsBox = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // resultBox
            // 
            resultBox.FormattingEnabled = true;
            resultBox.ItemHeight = 25;
            resultBox.Location = new Point(613, 277);
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(1252, 504);
            resultBox.TabIndex = 0;
            resultBox.SelectedIndexChanged += resultBox_SelectedIndexChanged;
            // 
            // buyBtn
            // 
            buyBtn.BackColor = Color.SaddleBrown;
            buyBtn.FlatAppearance.BorderSize = 0;
            buyBtn.FlatStyle = FlatStyle.Flat;
            buyBtn.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buyBtn.ForeColor = Color.White;
            buyBtn.Location = new Point(726, 847);
            buyBtn.Name = "buyBtn";
            buyBtn.Size = new Size(112, 34);
            buyBtn.TabIndex = 1;
            buyBtn.Text = "Kup";
            buyBtn.UseVisualStyleBackColor = false;
            buyBtn.Click += buyBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1914, 1074);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // characterStatisticsBox
            // 
            characterStatisticsBox.Location = new Point(56, 277);
            characterStatisticsBox.Name = "characterStatisticsBox";
            characterStatisticsBox.Size = new Size(488, 504);
            characterStatisticsBox.TabIndex = 3;
            characterStatisticsBox.Text = "";
            // 
            // SpellShopView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(characterStatisticsBox);
            Controls.Add(buyBtn);
            Controls.Add(resultBox);
            Controls.Add(pictureBox1);
            Name = "SpellShopView";
            Size = new Size(1920, 1080);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox resultBox;
        private components.WoodButton buyBtn;
        private PictureBox pictureBox1;
        private RichTextBox characterStatisticsBox;
    }
}
