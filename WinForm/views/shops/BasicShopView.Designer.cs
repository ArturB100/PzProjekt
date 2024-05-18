namespace WinForm.views.shops
{
    partial class BasicShopView
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
            buyBtn = new components.WoodButton();
            listBox = new ListBox();
            characterStatisticsBox = new RichTextBox();
            SuspendLayout();
            // 
            // buyBtn
            // 
            buyBtn.BackColor = Color.SaddleBrown;
            buyBtn.FlatAppearance.BorderSize = 0;
            buyBtn.FlatStyle = FlatStyle.Flat;
            buyBtn.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buyBtn.ForeColor = Color.White;
            buyBtn.Location = new Point(793, 942);
            buyBtn.Name = "buyBtn";
            buyBtn.Size = new Size(112, 34);
            buyBtn.TabIndex = 0;
            buyBtn.Text = "Kup";
            buyBtn.UseVisualStyleBackColor = false;
            buyBtn.Click += buyBtn_Click;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 25;
            listBox.Location = new Point(575, 446);
            listBox.Name = "listBox";
            listBox.Size = new Size(1303, 454);
            listBox.TabIndex = 1;
            listBox.SelectedIndexChanged += resultBox_SelectedIndexChanged;
            // 
            // characterStatisticsBox
            // 
            characterStatisticsBox.Location = new Point(24, 446);
            characterStatisticsBox.Name = "characterStatisticsBox";
            characterStatisticsBox.Size = new Size(485, 454);
            characterStatisticsBox.TabIndex = 2;
            characterStatisticsBox.Text = "";
            // 
            // BasicShopView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(characterStatisticsBox);
            Controls.Add(listBox);
            Controls.Add(buyBtn);
            Name = "BasicShopView";
            Size = new Size(1920, 1080);
            ResumeLayout(false);
        }

        #endregion

        private components.WoodButton buyBtn;
        private ListBox listBox;
        private RichTextBox characterStatisticsBox;
    }
}
