namespace WinForm.views
{
    partial class Weaponsmith
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
            label1 = new Label();
            resultTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(819, 42);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 0;
            label1.Text = "Kuźnia";
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(418, 390);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(1003, 640);
            resultTextBox.TabIndex = 1;
            resultTextBox.Text = "";
            // 
            // Weaponsmith
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(resultTextBox);
            Controls.Add(label1);
            Name = "Weaponsmith";
            Size = new Size(1920, 1080);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox resultTextBox;
    }
}
