namespace WinForm
{
    partial class UserControlBase
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
            menu = new MenuStrip();
            stronaGlownaToolStripMenuItem = new ToolStripMenuItem();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(24, 24);
            menu.Items.AddRange(new ToolStripItem[] { stronaGlownaToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(1920, 33);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // stronaGlownaToolStripMenuItem
            // 
            stronaGlownaToolStripMenuItem.Name = "stronaGlownaToolStripMenuItem";
            stronaGlownaToolStripMenuItem.Size = new Size(142, 29);
            stronaGlownaToolStripMenuItem.Text = "Strona glowna";
            stronaGlownaToolStripMenuItem.Click += stronaGlownaToolStripMenuItem_Click;
            // 
            // UserControlBase
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(menu);
            Name = "UserControlBase";
<<<<<<< Updated upstream
=======
            Size = new Size(1920, 1080);
            menu.ResumeLayout(false);
            menu.PerformLayout();
>>>>>>> Stashed changes
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem stronaGlownaToolStripMenuItem;
    }
}
