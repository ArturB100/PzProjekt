﻿namespace WinForm.views
{
    partial class WeaponsmithView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeaponsmithView));
            label1 = new Label();
            swordPic = new PictureBox();
            axePic = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)swordPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)axePic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(857, 54);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 0;
            label1.Text = "Kuźnia";
            // 
            // swordPic
            // 
            swordPic.Image = (Image)resources.GetObject("swordPic.Image");
            swordPic.Location = new Point(492, 197);
            swordPic.Name = "swordPic";
            swordPic.Size = new Size(251, 190);
            swordPic.SizeMode = PictureBoxSizeMode.Zoom;
            swordPic.TabIndex = 3;
            swordPic.TabStop = false;
            swordPic.Click += swordPic_Click;
            // 
            // axePic
            // 
            axePic.Image = (Image)resources.GetObject("axePic.Image");
            axePic.Location = new Point(1036, 197);
            axePic.Name = "axePic";
            axePic.Size = new Size(251, 190);
            axePic.SizeMode = PictureBoxSizeMode.Zoom;
            axePic.TabIndex = 4;
            axePic.TabStop = false;
            axePic.Click += axePic_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1917, 1074);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // WeaponsmithView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(axePic);
            Controls.Add(swordPic);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "WeaponsmithView";
            Size = new Size(1920, 1080);
            ((System.ComponentModel.ISupportInitialize)swordPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)axePic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox swordPic;
        private PictureBox axePic;
        private PictureBox pictureBox1;
    }
}
