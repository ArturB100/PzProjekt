namespace WinForm.views
{
    partial class SinglePlayerGameSelectView
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
            gameSelectPanel1 = new components.GameSelectPanel();
            gameSelectPanel2 = new components.GameSelectPanel();
            SuspendLayout();
            // 
            // gameSelectPanel1
            // 
            gameSelectPanel1.Location = new Point(548, 73);
            gameSelectPanel1.Name = "gameSelectPanel1";
            gameSelectPanel1.Size = new Size(1332, 261);
            gameSelectPanel1.TabIndex = 0;
            // 
            // gameSelectPanel2
            // 
            gameSelectPanel2.Location = new Point(548, 371);
            gameSelectPanel2.Name = "gameSelectPanel2";
            gameSelectPanel2.Size = new Size(1332, 261);
            gameSelectPanel2.TabIndex = 1;
            // 
            // SinglePlayerGameSelectView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gameSelectPanel2);
            Controls.Add(gameSelectPanel1);
            Name = "SinglePlayerGameSelectView";
            Size = new Size(2540, 1440);
            ResumeLayout(false);
        }

        #endregion

        private components.GameSelectPanel gameSelectPanel1;
        private components.GameSelectPanel gameSelectPanel2;
    }
}
