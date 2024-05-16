namespace WinForm.views
{
    partial class SelectedCharacterDetailsView
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
            characterDetails = new RichTextBox();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // characterDetails
            // 
            characterDetails.Location = new Point(395, 424);
            characterDetails.Name = "characterDetails";
            characterDetails.Size = new Size(1063, 527);
            characterDetails.TabIndex = 0;
            characterDetails.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1920, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(135, 29);
            menuToolStripMenuItem.Text = "Ekran Glowny";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // SelectedCharacterDetailsView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(characterDetails);
            Controls.Add(menuStrip1);
            Name = "SelectedCharacterDetailsView";
            Size = new Size(1920, 1080);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox characterDetails;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
    }
}
