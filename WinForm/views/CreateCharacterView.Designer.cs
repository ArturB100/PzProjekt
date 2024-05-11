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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCharacterView));
            titleLabel = new Label();
            nameInp = new TextBox();
            label1 = new Label();
            pointsToInvestLabel = new Label();
            strengthMinusBtn = new Button();
            strengthPlusBtn = new Button();
            strengthCurrentValue = new Label();
            label3 = new Label();
            label2 = new Label();
            AgilityCurrentValue = new Label();
            agilityPlusBtn = new Button();
            agilityMinusBtn = new Button();
            label5 = new Label();
            AttackCurrentValue = new Label();
            attackPlusBtn = new Button();
            attackMinusBtn = new Button();
            label7 = new Label();
            defenceCurrentValue = new Label();
            defencePlusBtn = new Button();
            defenceMinusBtn = new Button();
            label9 = new Label();
            vitalityCurrentValue = new Label();
            vitalityPlusBtn = new Button();
            vitalityMinusBtn = new Button();
            label11 = new Label();
            charismaCurrentValue = new Label();
            charismaPlusBtn = new Button();
            charismaMinusBtn = new Button();
            label13 = new Label();
            staminaCurrentValue = new Label();
            staminaPlusBtn = new Button();
            staminaMinusBtn = new Button();
            label15 = new Label();
            intelligenceCurrentValue = new Label();
            intelligencePlusBtn = new Button();
            intelligenceMinusBtn = new Button();
            label17 = new Label();
            magicaCurrentValue = new Label();
            magicaPlusBtn = new Button();
            magicaMinusBtn = new Button();
            button1 = new Button();
            characterImage = new PictureBox();
            characterHeadImage = new PictureBox();
            uploadHeadImageBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)characterImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)characterHeadImage).BeginInit();
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
            nameInp.TextChanged += nameInp_TextChanged;
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
            // strengthMinusBtn
            // 
            strengthMinusBtn.Location = new Point(373, 412);
            strengthMinusBtn.Name = "strengthMinusBtn";
            strengthMinusBtn.Size = new Size(35, 36);
            strengthMinusBtn.TabIndex = 5;
            strengthMinusBtn.Text = "-";
            strengthMinusBtn.UseVisualStyleBackColor = true;
            strengthMinusBtn.Click += strengthMinusBtn_Click;
            // 
            // strengthPlusBtn
            // 
            strengthPlusBtn.Location = new Point(424, 412);
            strengthPlusBtn.Name = "strengthPlusBtn";
            strengthPlusBtn.Size = new Size(35, 36);
            strengthPlusBtn.TabIndex = 6;
            strengthPlusBtn.Text = "+";
            strengthPlusBtn.UseVisualStyleBackColor = true;
            strengthPlusBtn.Click += strengthPlusBtn_Click;
            // 
            // strengthCurrentValue
            // 
            strengthCurrentValue.AutoSize = true;
            strengthCurrentValue.Location = new Point(473, 418);
            strengthCurrentValue.Name = "strengthCurrentValue";
            strengthCurrentValue.Size = new Size(59, 25);
            strengthCurrentValue.TabIndex = 7;
            strengthCurrentValue.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(558, 418);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 8;
            label3.Text = "Strength";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(558, 473);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 12;
            label2.Text = "Agility";
            label2.Click += label2_Click;
            // 
            // AgilityCurrentValue
            // 
            AgilityCurrentValue.AutoSize = true;
            AgilityCurrentValue.Location = new Point(473, 473);
            AgilityCurrentValue.Name = "AgilityCurrentValue";
            AgilityCurrentValue.Size = new Size(59, 25);
            AgilityCurrentValue.TabIndex = 11;
            AgilityCurrentValue.Text = "label2";
            // 
            // agilityPlusBtn
            // 
            agilityPlusBtn.Location = new Point(424, 467);
            agilityPlusBtn.Name = "agilityPlusBtn";
            agilityPlusBtn.Size = new Size(35, 36);
            agilityPlusBtn.TabIndex = 10;
            agilityPlusBtn.Text = "+";
            agilityPlusBtn.UseVisualStyleBackColor = true;
            agilityPlusBtn.Click += agilityPlusBtn_Click;
            // 
            // agilityMinusBtn
            // 
            agilityMinusBtn.Location = new Point(373, 467);
            agilityMinusBtn.Name = "agilityMinusBtn";
            agilityMinusBtn.Size = new Size(35, 36);
            agilityMinusBtn.TabIndex = 9;
            agilityMinusBtn.Text = "-";
            agilityMinusBtn.UseVisualStyleBackColor = true;
            agilityMinusBtn.Click += agilityMinusBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(558, 526);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 16;
            label5.Text = "Attack";
            // 
            // AttackCurrentValue
            // 
            AttackCurrentValue.AutoSize = true;
            AttackCurrentValue.Location = new Point(473, 526);
            AttackCurrentValue.Name = "AttackCurrentValue";
            AttackCurrentValue.Size = new Size(59, 25);
            AttackCurrentValue.TabIndex = 15;
            AttackCurrentValue.Text = "label2";
            // 
            // attackPlusBtn
            // 
            attackPlusBtn.Location = new Point(424, 520);
            attackPlusBtn.Name = "attackPlusBtn";
            attackPlusBtn.Size = new Size(35, 36);
            attackPlusBtn.TabIndex = 14;
            attackPlusBtn.Text = "+";
            attackPlusBtn.UseVisualStyleBackColor = true;
            attackPlusBtn.Click += attackPlusBtn_Click;
            // 
            // attackMinusBtn
            // 
            attackMinusBtn.Location = new Point(373, 520);
            attackMinusBtn.Name = "attackMinusBtn";
            attackMinusBtn.Size = new Size(35, 36);
            attackMinusBtn.TabIndex = 13;
            attackMinusBtn.Text = "-";
            attackMinusBtn.UseVisualStyleBackColor = true;
            attackMinusBtn.Click += attackMinusBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(558, 584);
            label7.Name = "label7";
            label7.Size = new Size(76, 25);
            label7.TabIndex = 20;
            label7.Text = "Defence";
            // 
            // defenceCurrentValue
            // 
            defenceCurrentValue.AutoSize = true;
            defenceCurrentValue.Location = new Point(473, 584);
            defenceCurrentValue.Name = "defenceCurrentValue";
            defenceCurrentValue.Size = new Size(59, 25);
            defenceCurrentValue.TabIndex = 19;
            defenceCurrentValue.Text = "label2";
            // 
            // defencePlusBtn
            // 
            defencePlusBtn.Location = new Point(424, 578);
            defencePlusBtn.Name = "defencePlusBtn";
            defencePlusBtn.Size = new Size(35, 36);
            defencePlusBtn.TabIndex = 18;
            defencePlusBtn.Text = "+";
            defencePlusBtn.UseVisualStyleBackColor = true;
            defencePlusBtn.Click += defencePlusBtn_Click;
            // 
            // defenceMinusBtn
            // 
            defenceMinusBtn.Location = new Point(373, 578);
            defenceMinusBtn.Name = "defenceMinusBtn";
            defenceMinusBtn.Size = new Size(35, 36);
            defenceMinusBtn.TabIndex = 17;
            defenceMinusBtn.Text = "-";
            defenceMinusBtn.UseVisualStyleBackColor = true;
            defenceMinusBtn.Click += defenceMinusBtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(558, 637);
            label9.Name = "label9";
            label9.Size = new Size(65, 25);
            label9.TabIndex = 24;
            label9.Text = "Vitality";
            // 
            // vitalityCurrentValue
            // 
            vitalityCurrentValue.AutoSize = true;
            vitalityCurrentValue.Location = new Point(473, 637);
            vitalityCurrentValue.Name = "vitalityCurrentValue";
            vitalityCurrentValue.Size = new Size(59, 25);
            vitalityCurrentValue.TabIndex = 23;
            vitalityCurrentValue.Text = "label2";
            // 
            // vitalityPlusBtn
            // 
            vitalityPlusBtn.Location = new Point(424, 631);
            vitalityPlusBtn.Name = "vitalityPlusBtn";
            vitalityPlusBtn.Size = new Size(35, 36);
            vitalityPlusBtn.TabIndex = 22;
            vitalityPlusBtn.Text = "+";
            vitalityPlusBtn.UseVisualStyleBackColor = true;
            vitalityPlusBtn.Click += vitalityPlusBtn_Click;
            // 
            // vitalityMinusBtn
            // 
            vitalityMinusBtn.Location = new Point(373, 631);
            vitalityMinusBtn.Name = "vitalityMinusBtn";
            vitalityMinusBtn.Size = new Size(35, 36);
            vitalityMinusBtn.TabIndex = 21;
            vitalityMinusBtn.Text = "-";
            vitalityMinusBtn.UseVisualStyleBackColor = true;
            vitalityMinusBtn.Click += vitalityMinusBtn_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(558, 693);
            label11.Name = "label11";
            label11.Size = new Size(85, 25);
            label11.TabIndex = 28;
            label11.Text = "Charisma";
            // 
            // charismaCurrentValue
            // 
            charismaCurrentValue.AutoSize = true;
            charismaCurrentValue.Location = new Point(473, 693);
            charismaCurrentValue.Name = "charismaCurrentValue";
            charismaCurrentValue.Size = new Size(59, 25);
            charismaCurrentValue.TabIndex = 27;
            charismaCurrentValue.Text = "label2";
            // 
            // charismaPlusBtn
            // 
            charismaPlusBtn.Location = new Point(424, 687);
            charismaPlusBtn.Name = "charismaPlusBtn";
            charismaPlusBtn.Size = new Size(35, 36);
            charismaPlusBtn.TabIndex = 26;
            charismaPlusBtn.Text = "+";
            charismaPlusBtn.UseVisualStyleBackColor = true;
            charismaPlusBtn.Click += charismaPlusBtn_Click;
            // 
            // charismaMinusBtn
            // 
            charismaMinusBtn.Location = new Point(373, 687);
            charismaMinusBtn.Name = "charismaMinusBtn";
            charismaMinusBtn.Size = new Size(35, 36);
            charismaMinusBtn.TabIndex = 25;
            charismaMinusBtn.Text = "-";
            charismaMinusBtn.UseVisualStyleBackColor = true;
            charismaMinusBtn.Click += charismaMinusBtn_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(558, 749);
            label13.Name = "label13";
            label13.Size = new Size(75, 25);
            label13.TabIndex = 32;
            label13.Text = "Stamina";
            // 
            // staminaCurrentValue
            // 
            staminaCurrentValue.AutoSize = true;
            staminaCurrentValue.Location = new Point(473, 749);
            staminaCurrentValue.Name = "staminaCurrentValue";
            staminaCurrentValue.Size = new Size(59, 25);
            staminaCurrentValue.TabIndex = 31;
            staminaCurrentValue.Text = "label2";
            // 
            // staminaPlusBtn
            // 
            staminaPlusBtn.Location = new Point(424, 743);
            staminaPlusBtn.Name = "staminaPlusBtn";
            staminaPlusBtn.Size = new Size(35, 36);
            staminaPlusBtn.TabIndex = 30;
            staminaPlusBtn.Text = "+";
            staminaPlusBtn.UseVisualStyleBackColor = true;
            staminaPlusBtn.Click += staminaPlusBtn_Click;
            // 
            // staminaMinusBtn
            // 
            staminaMinusBtn.Location = new Point(373, 743);
            staminaMinusBtn.Name = "staminaMinusBtn";
            staminaMinusBtn.Size = new Size(35, 36);
            staminaMinusBtn.TabIndex = 29;
            staminaMinusBtn.Text = "-";
            staminaMinusBtn.UseVisualStyleBackColor = true;
            staminaMinusBtn.Click += staminaMinusBtn_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(558, 867);
            label15.Name = "label15";
            label15.Size = new Size(101, 25);
            label15.TabIndex = 36;
            label15.Text = "Intelligence";
            // 
            // intelligenceCurrentValue
            // 
            intelligenceCurrentValue.AutoSize = true;
            intelligenceCurrentValue.Location = new Point(473, 867);
            intelligenceCurrentValue.Name = "intelligenceCurrentValue";
            intelligenceCurrentValue.Size = new Size(59, 25);
            intelligenceCurrentValue.TabIndex = 35;
            intelligenceCurrentValue.Text = "label2";
            // 
            // intelligencePlusBtn
            // 
            intelligencePlusBtn.Location = new Point(424, 861);
            intelligencePlusBtn.Name = "intelligencePlusBtn";
            intelligencePlusBtn.Size = new Size(35, 36);
            intelligencePlusBtn.TabIndex = 34;
            intelligencePlusBtn.Text = "+";
            intelligencePlusBtn.UseVisualStyleBackColor = true;
            intelligencePlusBtn.Click += intelligencePlusBtn_Click;
            // 
            // intelligenceMinusBtn
            // 
            intelligenceMinusBtn.Location = new Point(373, 861);
            intelligenceMinusBtn.Name = "intelligenceMinusBtn";
            intelligenceMinusBtn.Size = new Size(35, 36);
            intelligenceMinusBtn.TabIndex = 33;
            intelligenceMinusBtn.Text = "-";
            intelligenceMinusBtn.UseVisualStyleBackColor = true;
            intelligenceMinusBtn.Click += intelligenceMinusBtn_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(558, 810);
            label17.Name = "label17";
            label17.Size = new Size(69, 25);
            label17.TabIndex = 40;
            label17.Text = "Magica";
            // 
            // magicaCurrentValue
            // 
            magicaCurrentValue.AutoSize = true;
            magicaCurrentValue.Location = new Point(473, 810);
            magicaCurrentValue.Name = "magicaCurrentValue";
            magicaCurrentValue.Size = new Size(59, 25);
            magicaCurrentValue.TabIndex = 39;
            magicaCurrentValue.Text = "label2";
            // 
            // magicaPlusBtn
            // 
            magicaPlusBtn.Location = new Point(424, 804);
            magicaPlusBtn.Name = "magicaPlusBtn";
            magicaPlusBtn.Size = new Size(35, 36);
            magicaPlusBtn.TabIndex = 38;
            magicaPlusBtn.Text = "+";
            magicaPlusBtn.UseVisualStyleBackColor = true;
            magicaPlusBtn.Click += magicaPlusBtn_Click;
            // 
            // magicaMinusBtn
            // 
            magicaMinusBtn.Location = new Point(373, 804);
            magicaMinusBtn.Name = "magicaMinusBtn";
            magicaMinusBtn.Size = new Size(35, 36);
            magicaMinusBtn.TabIndex = 37;
            magicaMinusBtn.Text = "-";
            magicaMinusBtn.UseVisualStyleBackColor = true;
            magicaMinusBtn.Click += magicaMinusBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1481, 934);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 41;
            button1.Text = "dalej";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // characterImage
            // 
            characterImage.Image = (Image)resources.GetObject("characterImage.Image");
            characterImage.InitialImage = (Image)resources.GetObject("characterImage.InitialImage");
            characterImage.Location = new Point(930, 399);
            characterImage.Name = "characterImage";
            characterImage.Size = new Size(395, 498);
            characterImage.TabIndex = 42;
            characterImage.TabStop = false;
            // 
            // characterHeadImage
            // 
            characterHeadImage.Image = (Image)resources.GetObject("characterHeadImage.Image");
            characterHeadImage.InitialImage = (Image)resources.GetObject("characterHeadImage.InitialImage");
            characterHeadImage.Location = new Point(1059, 399);
            characterHeadImage.Name = "characterHeadImage";
            characterHeadImage.Size = new Size(162, 133);
            characterHeadImage.SizeMode = PictureBoxSizeMode.StretchImage;
            characterHeadImage.TabIndex = 43;
            characterHeadImage.TabStop = false;
            // 
            // uploadHeadImageBtn
            // 
            uploadHeadImageBtn.Location = new Point(1294, 329);
            uploadHeadImageBtn.Name = "uploadHeadImageBtn";
            uploadHeadImageBtn.Size = new Size(233, 34);
            uploadHeadImageBtn.TabIndex = 44;
            uploadHeadImageBtn.Text = "wybierz zdjęcie";
            uploadHeadImageBtn.UseVisualStyleBackColor = true;
            uploadHeadImageBtn.Click += uploadHeadImageBtn_Click;
            // 
            // CreateCharacterView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(uploadHeadImageBtn);
            Controls.Add(characterHeadImage);
            Controls.Add(characterImage);
            Controls.Add(button1);
            Controls.Add(label17);
            Controls.Add(magicaCurrentValue);
            Controls.Add(magicaPlusBtn);
            Controls.Add(magicaMinusBtn);
            Controls.Add(label15);
            Controls.Add(intelligenceCurrentValue);
            Controls.Add(intelligencePlusBtn);
            Controls.Add(intelligenceMinusBtn);
            Controls.Add(label13);
            Controls.Add(staminaCurrentValue);
            Controls.Add(staminaPlusBtn);
            Controls.Add(staminaMinusBtn);
            Controls.Add(label11);
            Controls.Add(charismaCurrentValue);
            Controls.Add(charismaPlusBtn);
            Controls.Add(charismaMinusBtn);
            Controls.Add(label9);
            Controls.Add(vitalityCurrentValue);
            Controls.Add(vitalityPlusBtn);
            Controls.Add(vitalityMinusBtn);
            Controls.Add(label7);
            Controls.Add(defenceCurrentValue);
            Controls.Add(defencePlusBtn);
            Controls.Add(defenceMinusBtn);
            Controls.Add(label5);
            Controls.Add(AttackCurrentValue);
            Controls.Add(attackPlusBtn);
            Controls.Add(attackMinusBtn);
            Controls.Add(label2);
            Controls.Add(AgilityCurrentValue);
            Controls.Add(agilityPlusBtn);
            Controls.Add(agilityMinusBtn);
            Controls.Add(label3);
            Controls.Add(strengthCurrentValue);
            Controls.Add(strengthPlusBtn);
            Controls.Add(strengthMinusBtn);
            Controls.Add(pointsToInvestLabel);
            Controls.Add(label1);
            Controls.Add(nameInp);
            Controls.Add(titleLabel);
            Name = "CreateCharacterView";
            Size = new Size(1920, 1080);
            ((System.ComponentModel.ISupportInitialize)characterImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)characterHeadImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private TextBox nameInp;
        private Label label1;
        private Label pointsToInvestLabel;
        private Button strengthMinusBtn;
        private Button strengthPlusBtn;
        private Label strengthCurrentValue;
        private Label label3;
        private Label label2;
        private Label AgilityCurrentValue;
        private Button agilityPlusBtn;
        private Button agilityMinusBtn;
        private Label label5;
        private Label AttackCurrentValue;
        private Button attackPlusBtn;
        private Button attackMinusBtn;
        private Label label7;
        private Label defenceCurrentValue;
        private Button defencePlusBtn;
        private Button defenceMinusBtn;
        private Label label9;
        private Label vitalityCurrentValue;
        private Button vitalityPlusBtn;
        private Button vitalityMinusBtn;
        private Label label11;
        private Label charismaCurrentValue;
        private Button charismaPlusBtn;
        private Button charismaMinusBtn;
        private Label label13;
        private Label staminaCurrentValue;
        private Button staminaPlusBtn;
        private Button staminaMinusBtn;
        private Label label15;
        private Label intelligenceCurrentValue;
        private Button intelligencePlusBtn;
        private Button intelligenceMinusBtn;
        private Label label17;
        private Label magicaCurrentValue;
        private Button magicaPlusBtn;
        private Button magicaMinusBtn;
        private Button button1;
        private PictureBox characterImage;
        private PictureBox characterHeadImage;
        private Button uploadHeadImageBtn;
    }
}
