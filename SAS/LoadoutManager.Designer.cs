namespace SAS
{
    partial class LoadoutManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadoutManager));
            ArmorBox = new ComboBox();
            PrimaryBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            SecondaryBox = new ComboBox();
            label3 = new Label();
            GrenadeBox = new ComboBox();
            label4 = new Label();
            FirstStratagem = new ComboBox();
            SecondStratagem = new ComboBox();
            ThirdStratagem = new ComboBox();
            FourthStratagem = new ComboBox();
            Booster = new ComboBox();
            SaveLoadout = new Button();
            Reset = new Button();
            TotalCost = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // ArmorBox
            // 
            ArmorBox.FormattingEnabled = true;
            ArmorBox.Location = new Point(382, 12);
            ArmorBox.Name = "ArmorBox";
            ArmorBox.Size = new Size(121, 23);
            ArmorBox.TabIndex = 0;
            ArmorBox.SelectedIndexChanged += ArmorBox_SelectedIndexChanged;
            // 
            // PrimaryBox
            // 
            PrimaryBox.FormattingEnabled = true;
            PrimaryBox.Location = new Point(382, 41);
            PrimaryBox.Name = "PrimaryBox";
            PrimaryBox.Size = new Size(121, 23);
            PrimaryBox.TabIndex = 1;
            PrimaryBox.SelectedIndexChanged += PrimaryBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 15);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 2;
            label1.Text = "Armor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(331, 44);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 3;
            label2.Text = "Primary";
            // 
            // SecondaryBox
            // 
            SecondaryBox.FormattingEnabled = true;
            SecondaryBox.Location = new Point(382, 70);
            SecondaryBox.Name = "SecondaryBox";
            SecondaryBox.Size = new Size(121, 23);
            SecondaryBox.TabIndex = 4;
            SecondaryBox.SelectedIndexChanged += SecondaryBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(317, 73);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 5;
            label3.Text = "Secondary";
            // 
            // GrenadeBox
            // 
            GrenadeBox.FormattingEnabled = true;
            GrenadeBox.Location = new Point(382, 99);
            GrenadeBox.Name = "GrenadeBox";
            GrenadeBox.Size = new Size(121, 23);
            GrenadeBox.TabIndex = 6;
            GrenadeBox.SelectedIndexChanged += GrenadeBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(325, 102);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 7;
            label4.Text = "Grenade";
            // 
            // FirstStratagem
            // 
            FirstStratagem.FormattingEnabled = true;
            FirstStratagem.Location = new Point(12, 344);
            FirstStratagem.Name = "FirstStratagem";
            FirstStratagem.Size = new Size(88, 23);
            FirstStratagem.TabIndex = 8;
            FirstStratagem.SelectedIndexChanged += FirstStratagem_SelectedIndexChanged;
            // 
            // SecondStratagem
            // 
            SecondStratagem.FormattingEnabled = true;
            SecondStratagem.Location = new Point(106, 344);
            SecondStratagem.Name = "SecondStratagem";
            SecondStratagem.Size = new Size(88, 23);
            SecondStratagem.TabIndex = 9;
            SecondStratagem.SelectedIndexChanged += SecondStratagem_SelectedIndexChanged;
            // 
            // ThirdStratagem
            // 
            ThirdStratagem.FormattingEnabled = true;
            ThirdStratagem.Location = new Point(200, 344);
            ThirdStratagem.Name = "ThirdStratagem";
            ThirdStratagem.Size = new Size(88, 23);
            ThirdStratagem.TabIndex = 10;
            ThirdStratagem.SelectedIndexChanged += ThirdStratagem_SelectedIndexChanged;
            // 
            // FourthStratagem
            // 
            FourthStratagem.FormattingEnabled = true;
            FourthStratagem.Location = new Point(294, 344);
            FourthStratagem.Name = "FourthStratagem";
            FourthStratagem.Size = new Size(88, 23);
            FourthStratagem.TabIndex = 11;
            FourthStratagem.SelectedIndexChanged += FourthStratagem_SelectedIndexChanged;
            // 
            // Booster
            // 
            Booster.FormattingEnabled = true;
            Booster.Location = new Point(408, 344);
            Booster.Name = "Booster";
            Booster.Size = new Size(88, 23);
            Booster.TabIndex = 12;
            Booster.SelectedIndexChanged += Booster_SelectedIndexChanged;
            // 
            // SaveLoadout
            // 
            SaveLoadout.Location = new Point(408, 373);
            SaveLoadout.Name = "SaveLoadout";
            SaveLoadout.Size = new Size(88, 65);
            SaveLoadout.TabIndex = 13;
            SaveLoadout.Text = "Buy";
            SaveLoadout.UseVisualStyleBackColor = true;
            SaveLoadout.Click += SaveLoadout_Click;
            // 
            // Reset
            // 
            Reset.Location = new Point(314, 373);
            Reset.Name = "Reset";
            Reset.Size = new Size(88, 65);
            Reset.TabIndex = 14;
            Reset.Text = "Reset";
            Reset.UseVisualStyleBackColor = true;
            // 
            // TotalCost
            // 
            TotalCost.AutoSize = true;
            TotalCost.Location = new Point(382, 125);
            TotalCost.Name = "TotalCost";
            TotalCost.Size = new Size(0, 15);
            TotalCost.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 176);
            label5.Name = "label5";
            label5.Size = new Size(336, 30);
            label5.TabIndex = 16;
            label5.Text = "THIS IS A BETA VERSION THERE COULD BE BUGS\r\nI WILL BE WORKING ON IMAGES AND OTHER STUFF LATER ON\r\n";
            // 
            // LoadoutManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 442);
            Controls.Add(label5);
            Controls.Add(TotalCost);
            Controls.Add(Reset);
            Controls.Add(SaveLoadout);
            Controls.Add(Booster);
            Controls.Add(FourthStratagem);
            Controls.Add(ThirdStratagem);
            Controls.Add(SecondStratagem);
            Controls.Add(FirstStratagem);
            Controls.Add(label4);
            Controls.Add(GrenadeBox);
            Controls.Add(label3);
            Controls.Add(SecondaryBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PrimaryBox);
            Controls.Add(ArmorBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoadoutManager";
            Text = "LoadoutManager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ArmorBox;
        private ComboBox PrimaryBox;
        private Label label1;
        private Label label2;
        private ComboBox SecondaryBox;
        private Label label3;
        private ComboBox GrenadeBox;
        private Label label4;
        private ComboBox FirstStratagem;
        private ComboBox SecondStratagem;
        private ComboBox ThirdStratagem;
        private ComboBox FourthStratagem;
        private ComboBox Booster;
        private Button SaveLoadout;
        private Button Reset;
        private Label TotalCost;
        private Label label5;
    }
}