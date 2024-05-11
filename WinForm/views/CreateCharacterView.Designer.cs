namespace WinForm.views
{
    partial class CreateCharacterView
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
            titleLabel = new Label();
            nameInp = new TextBox();
            label1 = new Label();
            pointsToInvestLabel = new Label();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(862, 92);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(131, 25);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Kreator postaci";
            // 
            // nameInp
            // 
            nameInp.Location = new Point(369, 213);
            nameInp.Name = "nameInp";
            nameInp.Size = new Size(150, 31);
            nameInp.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(369, 309);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 3;
            label1.Text = "Punkty do wydania";
            // 
            // pointsToInvestLabel
            // 
            pointsToInvestLabel.AutoSize = true;
            pointsToInvestLabel.Location = new Point(558, 309);
            pointsToInvestLabel.Name = "pointsToInvestLabel";
            pointsToInvestLabel.Size = new Size(0, 25);
            pointsToInvestLabel.TabIndex = 4;
            // 
            // CreateCharacterView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pointsToInvestLabel);
            Controls.Add(label1);
            Controls.Add(nameInp);
            Controls.Add(titleLabel);
            Name = "CreateCharacterView";
            Size = new Size(1920, 1080);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private TextBox nameInp;
        private Label label1;
        private Label pointsToInvestLabel;
    }
}
