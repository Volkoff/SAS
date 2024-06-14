namespace SAS
{
    partial class MissionManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MissionManager));
            MissionDifficultyBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SmallBaseBox = new ComboBox();
            MediumBaseBox = new ComboBox();
            BigBaseBox = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ReinforcementsLeftBox = new TextBox();
            label9 = new Label();
            CommonSamplesText = new TextBox();
            label10 = new Label();
            RareSamplesText = new TextBox();
            label11 = new Label();
            SuperRareSamplesText = new TextBox();
            label12 = new Label();
            MissionTypeBox = new ComboBox();
            HelldiversExtractedBox = new TextBox();
            OperationType = new ComboBox();
            label13 = new Label();
            CompleteOperationYESNO = new ComboBox();
            BackpackYESNO = new ComboBox();
            SupportYESNO = new ComboBox();
            SaveButton = new Button();
            PointsGainLabel = new Label();
            CiviliansKilledLabel = new Label();
            CiviliansKilledBox = new TextBox();
            backpackCountBox = new TextBox();
            backpackLabel = new Label();
            countOfSupportWeaponsBox = new TextBox();
            supportWeaponLabel = new Label();
            SuspendLayout();
            // 
            // MissionDifficultyBox
            // 
            MissionDifficultyBox.FormattingEnabled = true;
            MissionDifficultyBox.Location = new Point(12, 12);
            MissionDifficultyBox.Name = "MissionDifficultyBox";
            MissionDifficultyBox.Size = new Size(114, 23);
            MissionDifficultyBox.TabIndex = 0;
            MissionDifficultyBox.SelectedIndexChanged += MissionDifficultyBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 15);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 1;
            label1.Text = "Mission Difficulty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 78);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 5;
            label2.Text = "Helldivers Extracted";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 102);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 8;
            label3.Text = "Backpack Extracted";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 129);
            label4.Name = "label4";
            label4.Size = new Size(148, 15);
            label4.TabIndex = 9;
            label4.Text = "Support Weapon Extracted";
            // 
            // SmallBaseBox
            // 
            SmallBaseBox.FormattingEnabled = true;
            SmallBaseBox.Location = new Point(12, 155);
            SmallBaseBox.Name = "SmallBaseBox";
            SmallBaseBox.Size = new Size(46, 23);
            SmallBaseBox.TabIndex = 12;
            SmallBaseBox.SelectedIndexChanged += SmallBaseBox_SelectedIndexChanged;
            // 
            // MediumBaseBox
            // 
            MediumBaseBox.FormattingEnabled = true;
            MediumBaseBox.Location = new Point(12, 184);
            MediumBaseBox.Name = "MediumBaseBox";
            MediumBaseBox.Size = new Size(46, 23);
            MediumBaseBox.TabIndex = 13;
            MediumBaseBox.SelectedIndexChanged += MediumBaseBox_SelectedIndexChanged;
            // 
            // BigBaseBox
            // 
            BigBaseBox.FormattingEnabled = true;
            BigBaseBox.Location = new Point(12, 213);
            BigBaseBox.Name = "BigBaseBox";
            BigBaseBox.Size = new Size(46, 23);
            BigBaseBox.TabIndex = 14;
            BigBaseBox.SelectedIndexChanged += BigBaseBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 158);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 15;
            label5.Text = "Small Bases Destroyed";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 187);
            label6.Name = "label6";
            label6.Size = new Size(140, 15);
            label6.TabIndex = 16;
            label6.Text = "Medium Bases Destroyed";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(69, 216);
            label7.Name = "label7";
            label7.Size = new Size(112, 15);
            label7.TabIndex = 17;
            label7.Text = "Big Bases Destroyed";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(346, 15);
            label8.Name = "label8";
            label8.Size = new Size(127, 15);
            label8.TabIndex = 20;
            label8.Text = "Completed Operation?";
            // 
            // ReinforcementsLeftBox
            // 
            ReinforcementsLeftBox.Location = new Point(12, 242);
            ReinforcementsLeftBox.Name = "ReinforcementsLeftBox";
            ReinforcementsLeftBox.Size = new Size(46, 23);
            ReinforcementsLeftBox.TabIndex = 21;
            ReinforcementsLeftBox.TextChanged += ReinforcementsLeftBox_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(69, 245);
            label9.Name = "label9";
            label9.Size = new Size(113, 15);
            label9.TabIndex = 22;
            label9.Text = "Reinforcements Left";
            // 
            // CommonSamplesText
            // 
            CommonSamplesText.Location = new Point(12, 271);
            CommonSamplesText.Name = "CommonSamplesText";
            CommonSamplesText.Size = new Size(46, 23);
            CommonSamplesText.TabIndex = 23;
            CommonSamplesText.TextChanged += CommonSamplesText_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(69, 274);
            label10.Name = "label10";
            label10.Size = new Size(157, 15);
            label10.TabIndex = 24;
            label10.Text = "Common Samples Extracted";
            // 
            // RareSamplesText
            // 
            RareSamplesText.Location = new Point(12, 300);
            RareSamplesText.Name = "RareSamplesText";
            RareSamplesText.Size = new Size(46, 23);
            RareSamplesText.TabIndex = 25;
            RareSamplesText.TextChanged += RareSamplesText_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(69, 303);
            label11.Name = "label11";
            label11.Size = new Size(129, 15);
            label11.TabIndex = 26;
            label11.Text = "Rare Samples Extracted";
            // 
            // SuperRareSamplesText
            // 
            SuperRareSamplesText.Location = new Point(12, 329);
            SuperRareSamplesText.Name = "SuperRareSamplesText";
            SuperRareSamplesText.Size = new Size(46, 23);
            SuperRareSamplesText.TabIndex = 27;
            SuperRareSamplesText.TextChanged += SuperRareSamplesText_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(69, 332);
            label12.Name = "label12";
            label12.Size = new Size(162, 15);
            label12.TabIndex = 28;
            label12.Text = "Super Rare Samples Extracted";
            // 
            // MissionTypeBox
            // 
            MissionTypeBox.FormattingEnabled = true;
            MissionTypeBox.Location = new Point(12, 41);
            MissionTypeBox.Name = "MissionTypeBox";
            MissionTypeBox.Size = new Size(114, 23);
            MissionTypeBox.TabIndex = 29;
            MissionTypeBox.SelectedIndexChanged += MissionTypeBox_SelectedIndexChanged;
            // 
            // HelldiversExtractedBox
            // 
            HelldiversExtractedBox.Location = new Point(12, 70);
            HelldiversExtractedBox.Name = "HelldiversExtractedBox";
            HelldiversExtractedBox.Size = new Size(46, 23);
            HelldiversExtractedBox.TabIndex = 30;
            HelldiversExtractedBox.TextChanged += HelldiversExtractedBox_TextChanged;
            // 
            // OperationType
            // 
            OperationType.FormattingEnabled = true;
            OperationType.Location = new Point(479, 12);
            OperationType.Name = "OperationType";
            OperationType.Size = new Size(113, 23);
            OperationType.TabIndex = 31;
            OperationType.Visible = false;
            OperationType.SelectedIndexChanged += OperationType_SelectedIndexChanged_1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(132, 44);
            label13.Name = "label13";
            label13.Size = new Size(75, 15);
            label13.TabIndex = 34;
            label13.Text = "Mission Type";
            // 
            // CompleteOperationYESNO
            // 
            CompleteOperationYESNO.FormattingEnabled = true;
            CompleteOperationYESNO.Location = new Point(280, 12);
            CompleteOperationYESNO.Name = "CompleteOperationYESNO";
            CompleteOperationYESNO.Size = new Size(60, 23);
            CompleteOperationYESNO.TabIndex = 35;
            CompleteOperationYESNO.SelectedIndexChanged += CompleteOperationYESNO_SelectedIndexChanged_1;
            // 
            // BackpackYESNO
            // 
            BackpackYESNO.FormattingEnabled = true;
            BackpackYESNO.Location = new Point(12, 99);
            BackpackYESNO.Name = "BackpackYESNO";
            BackpackYESNO.Size = new Size(46, 23);
            BackpackYESNO.TabIndex = 36;
            BackpackYESNO.SelectedIndexChanged += BackpackYESNO_SelectedIndexChanged_1;
            // 
            // SupportYESNO
            // 
            SupportYESNO.FormattingEnabled = true;
            SupportYESNO.Location = new Point(12, 126);
            SupportYESNO.Name = "SupportYESNO";
            SupportYESNO.Size = new Size(46, 23);
            SupportYESNO.TabIndex = 37;
            SupportYESNO.SelectedIndexChanged += SupportYESNO_SelectedIndexChanged_1;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(461, 300);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(131, 70);
            SaveButton.TabIndex = 38;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // PointsGainLabel
            // 
            PointsGainLabel.AutoSize = true;
            PointsGainLabel.Location = new Point(511, 107);
            PointsGainLabel.Name = "PointsGainLabel";
            PointsGainLabel.Size = new Size(44, 15);
            PointsGainLabel.TabIndex = 39;
            PointsGainLabel.Text = "label14";
            // 
            // CiviliansKilledLabel
            // 
            CiviliansKilledLabel.AutoSize = true;
            CiviliansKilledLabel.Location = new Point(265, 44);
            CiviliansKilledLabel.Name = "CiviliansKilledLabel";
            CiviliansKilledLabel.Size = new Size(83, 15);
            CiviliansKilledLabel.TabIndex = 43;
            CiviliansKilledLabel.Text = "Civilians Killed";
            CiviliansKilledLabel.Visible = false;
            // 
            // CiviliansKilledBox
            // 
            CiviliansKilledBox.Location = new Point(213, 41);
            CiviliansKilledBox.Name = "CiviliansKilledBox";
            CiviliansKilledBox.Size = new Size(46, 23);
            CiviliansKilledBox.TabIndex = 42;
            CiviliansKilledBox.Visible = false;
            CiviliansKilledBox.TextChanged += CiviliansKilledBox_TextChanged;
            // 
            // backpackCountBox
            // 
            backpackCountBox.Location = new Point(185, 99);
            backpackCountBox.Name = "backpackCountBox";
            backpackCountBox.Size = new Size(46, 23);
            backpackCountBox.TabIndex = 44;
            backpackCountBox.Visible = false;
            backpackCountBox.TextChanged += backpackCountBox_TextChanged_1;
            // 
            // backpackLabel
            // 
            backpackLabel.AutoSize = true;
            backpackLabel.Location = new Point(237, 102);
            backpackLabel.Name = "backpackLabel";
            backpackLabel.Size = new Size(70, 15);
            backpackLabel.TabIndex = 45;
            backpackLabel.Text = "How many?";
            backpackLabel.Visible = false;
            // 
            // countOfSupportWeaponsBox
            // 
            countOfSupportWeaponsBox.Location = new Point(223, 126);
            countOfSupportWeaponsBox.Name = "countOfSupportWeaponsBox";
            countOfSupportWeaponsBox.Size = new Size(46, 23);
            countOfSupportWeaponsBox.TabIndex = 46;
            countOfSupportWeaponsBox.Visible = false;
            countOfSupportWeaponsBox.TextChanged += countOfSupportWeaponsBox_TextChanged;
            // 
            // supportWeaponLabel
            // 
            supportWeaponLabel.AutoSize = true;
            supportWeaponLabel.Location = new Point(275, 129);
            supportWeaponLabel.Name = "supportWeaponLabel";
            supportWeaponLabel.Size = new Size(70, 15);
            supportWeaponLabel.TabIndex = 47;
            supportWeaponLabel.Text = "How many?";
            supportWeaponLabel.Visible = false;
            // 
            // MissionManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 398);
            Controls.Add(supportWeaponLabel);
            Controls.Add(countOfSupportWeaponsBox);
            Controls.Add(backpackLabel);
            Controls.Add(backpackCountBox);
            Controls.Add(CiviliansKilledLabel);
            Controls.Add(CiviliansKilledBox);
            Controls.Add(PointsGainLabel);
            Controls.Add(SaveButton);
            Controls.Add(SupportYESNO);
            Controls.Add(BackpackYESNO);
            Controls.Add(CompleteOperationYESNO);
            Controls.Add(label13);
            Controls.Add(OperationType);
            Controls.Add(HelldiversExtractedBox);
            Controls.Add(MissionTypeBox);
            Controls.Add(label12);
            Controls.Add(SuperRareSamplesText);
            Controls.Add(label11);
            Controls.Add(RareSamplesText);
            Controls.Add(label10);
            Controls.Add(CommonSamplesText);
            Controls.Add(label9);
            Controls.Add(ReinforcementsLeftBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(BigBaseBox);
            Controls.Add(MediumBaseBox);
            Controls.Add(SmallBaseBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MissionDifficultyBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MissionManager";
            Text = "MissionManager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox MissionDifficultyBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox SmallBaseBox;
        private ComboBox MediumBaseBox;
        private ComboBox BigBaseBox;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox ReinforcementsLeftBox;
        private Label label9;
        private TextBox CommonSamplesText;
        private Label label10;
        private TextBox RareSamplesText;
        private Label label11;
        private TextBox SuperRareSamplesText;
        private Label label12;
        private ComboBox MissionTypeBox;
        private TextBox HelldiversExtractedBox;
        private ComboBox OperationType;
        private Label label13;
        private ComboBox CompleteOperationYESNO;
        private ComboBox BackpackYESNO;
        private ComboBox SupportYESNO;
        private Button SaveButton;
        private Label PointsGainLabel;
        private Label CiviliansKilledLabel;
        private TextBox CiviliansKilledBox;
        private TextBox backpackCountBox;
        private Label backpackLabel;
        private TextBox countOfSupportWeaponsBox;
        private Label supportWeaponLabel;
    }
}