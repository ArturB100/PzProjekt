namespace WinForm.views.Arena
{
    partial class TournamentView
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
            nextFightBtn = new Button();
            playerTextBox = new RichTextBox();
            enemyTextBox = new RichTextBox();
            das = new Label();
            dsad = new Label();
            title = new Label();
            SuspendLayout();
            // 
            // nextFightBtn
            // 
            nextFightBtn.Location = new Point(771, 864);
            nextFightBtn.Name = "nextFightBtn";
            nextFightBtn.Size = new Size(284, 54);
            nextFightBtn.TabIndex = 0;
            nextFightBtn.Text = "kolejna walka";
            nextFightBtn.UseVisualStyleBackColor = true;
            nextFightBtn.Click += nextFightBtn_Click;
            // 
            // playerTextBox
            // 
            playerTextBox.Location = new Point(110, 272);
            playerTextBox.Name = "playerTextBox";
            playerTextBox.Size = new Size(664, 517);
            playerTextBox.TabIndex = 1;
            playerTextBox.Text = "";
            // 
            // enemyTextBox
            // 
            enemyTextBox.Location = new Point(1038, 272);
            enemyTextBox.Name = "enemyTextBox";
            enemyTextBox.Size = new Size(682, 517);
            enemyTextBox.TabIndex = 2;
            enemyTextBox.Text = "";
            // 
            // das
            // 
            das.AutoSize = true;
            das.Location = new Point(411, 212);
            das.Name = "das";
            das.Size = new Size(54, 25);
            das.TabIndex = 3;
            das.Text = "gracz";
            // 
            // dsad
            // 
            dsad.AutoSize = true;
            dsad.Location = new Point(1324, 212);
            dsad.Name = "dsad";
            dsad.Size = new Size(94, 25);
            dsad.TabIndex = 4;
            dsad.Text = "przeciwnik";
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new Point(831, 64);
            title.Name = "title";
            title.Size = new Size(59, 25);
            title.TabIndex = 5;
            title.Text = "label1";
            // 
            // TournamentView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(title);
            Controls.Add(dsad);
            Controls.Add(das);
            Controls.Add(enemyTextBox);
            Controls.Add(playerTextBox);
            Controls.Add(nextFightBtn);
            Name = "TournamentView";
            Size = new Size(1920, 1080);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button nextFightBtn;
        private RichTextBox playerTextBox;
        private RichTextBox enemyTextBox;
        private Label das;
        private Label dsad;
        private Label title;
    }
}
