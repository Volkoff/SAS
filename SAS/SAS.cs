using Microsoft.VisualBasic;

namespace SAS
{
    public partial class SAS : Form
    {
        public int currentPoints = 100;
        public SAS()
        {
            var userChoice = MessageBox.Show("Do you want to load points from a file?", "Load Points", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (userChoice == DialogResult.Yes)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "SAS Save File (*.sas)|*.sas";
                openFileDialog.Title = "Open SAS File";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string pointsData = File.ReadAllText(openFileDialog.FileName);
                        if (int.TryParse(pointsData, out int loadedPoints) && loadedPoints >= 0)
                        {
                            currentPoints = loadedPoints;
                        }
                        else
                        {
                            MessageBox.Show("Invalid data in file. Using default points (100).", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            currentPoints = 100;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to load points. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        currentPoints = 10; 
                    }
                }
                else
                {
                    currentPoints = 10;
                }
            }
            else
            {
                // Prompt for new points value as before
                string input = Interaction.InputBox("Enter initial points:", "Initial Points", "100", -1, -1);
                if (int.TryParse(input, out int initialPoints) && initialPoints >= 0)
                {
                    currentPoints = initialPoints;
                }
                else
                {
                    MessageBox.Show("Invalid input. Using default points (10).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    currentPoints = 10;
                }
            }
            this.BackgroundImage = Properties.Resources.helldiverslogo;
            this.BackgroundImageLayout = ImageLayout.Center;
            InitializeComponent();
            updatePoints();
        }
        private void updatePoints()
        {
            PointsTracker.Text = "Points: " + currentPoints;
        }
        public void button1_Click(object sender, EventArgs e)
        {
            new LoadoutManager(this).ShowDialog();
            updatePoints();
            return;
        }
        public void UpdateCurrentPoints(int cost)
        {
            currentPoints -= cost;
        }
        public void button2_Click(object sender, EventArgs e)
        {
            new MissionManager(this).ShowDialog();
            updatePoints();
            return;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string savePath = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "SAS Save File (*.sas)|*.sas";
            saveFileDialog.Title = "Save SAS File";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                savePath = saveFileDialog.FileName;
            }
            else
            {
                return;
            }
            using (StreamWriter writer = new StreamWriter(savePath))
            {
                writer.WriteLine(currentPoints);
            }
            MessageBox.Show("Save successful!", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
