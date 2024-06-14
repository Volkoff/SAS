namespace SAS
{
    partial class SAS
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SAS));
            button1 = new Button();
            PointsTracker = new Label();
            MissionButton = new Button();
            SaveButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(91, 51);
            button1.TabIndex = 0;
            button1.Text = "Change Loadout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PointsTracker
            // 
            PointsTracker.AutoSize = true;
            PointsTracker.Location = new Point(109, 30);
            PointsTracker.Name = "PointsTracker";
            PointsTracker.Size = new Size(14, 15);
            PointsTracker.TabIndex = 1;
            PointsTracker.Text = "o";
            // 
            // MissionButton
            // 
            MissionButton.Location = new Point(12, 69);
            MissionButton.Name = "MissionButton";
            MissionButton.Size = new Size(91, 48);
            MissionButton.TabIndex = 2;
            MissionButton.Text = "Mission";
            MissionButton.UseVisualStyleBackColor = true;
            MissionButton.Click += button2_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(224, 189);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(69, 43);
            SaveButton.TabIndex = 3;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // SAS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 244);
            Controls.Add(SaveButton);
            Controls.Add(MissionButton);
            Controls.Add(PointsTracker);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SAS";
            Text = "SAS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label PointsTracker;
        private Button MissionButton;
        private Button SaveButton;
    }
}
