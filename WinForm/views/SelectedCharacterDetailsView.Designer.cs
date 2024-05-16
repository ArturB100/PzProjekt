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
            SuspendLayout();
            // 
            // characterDetails
            // 
            characterDetails.Location = new Point(395, 424);
            characterDetails.Name = "characterDetails";
            characterDetails.Size = new Size(1063, 527);
            characterDetails.TabIndex = 0;
            characterDetails.Text = "";
            characterDetails.TextChanged += characterDetails_TextChanged;
            // 
            // SelectedCharacterDetailsView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(characterDetails);
            Name = "SelectedCharacterDetailsView";
            Size = new Size(1920, 1080);
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox characterDetails;
    }
}
