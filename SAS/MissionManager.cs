using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAS
{
    public partial class MissionManager : Form
    {
        private SAS parentForm;
        private int missionDifficulty;
        private string? missionType;
        private bool isOperationCompleted;
        private bool isBackpackExtracted;
        private bool isSupportWeaponExtracted;
        private int smallBase;
        private int mediumBase;
        private int bigBase;
        private int commonSamples;
        private int rareSamples;
        private int superRareSamples;
        private int pointsGained;
        private int civiliansExtracted;
        private int civiliansKilled;
        private int pointsGainedThroughMissionType = 0;
        private bool shouldBeDoubled;
        private int pointsFromSmallBase = 0;
        private int pointsFromMediumBase = 0;
        private int pointsFromBigBase = 0;
        private int pointsFromCommonSamples = 0;
        private int pointsFromRareSamples = 0;
        private int pointsFromSuperRareSamples = 0;
        private int pointsLostFromCiviliansKilled = 0;
        private int pointsFromOperation = 0;
        private int pointsGainedForDifficulty = 0;
        private int pointsFromBackpack = 0;
        private int pointsFromExtractedCivilians = 0;
        private int helldiversExtracted;
        private int reinforcementsLeft;
        private int pointsFromSupportWeapons;

        public MissionManager(SAS parent)
        {
            this.BackgroundImage = Properties.Resources.helldiverslogo;
            parentForm = parent;
            InitializeComponent();
            PopulateMissionDifficulty();
            PopulateMissionTypes();
            PopulateBaseSizes();
            PopulateYesNoDropDowns();
            SetControlsVisibility(false);
        }

        private void CalculatePoints()
        {
            pointsGained = 0;

            // Base points calculation
            pointsGained += pointsFromSmallBase;
            pointsGained += pointsFromMediumBase;
            pointsGained += pointsFromBigBase;
            pointsGained += pointsFromCommonSamples / 10;
            pointsGained += pointsFromRareSamples / 5;
            pointsGained += pointsFromSuperRareSamples / 2;
            pointsGained += pointsFromOperation;
            pointsGained += pointsGainedForDifficulty;
            pointsGained += pointsFromBackpack;
            pointsGained += pointsFromExtractedCivilians;
            pointsGained -= pointsLostFromCiviliansKilled;
            pointsGained += pointsFromSupportWeapons;

            if (reinforcementsLeft > 0 && helldiversExtracted > 0)
            {
                pointsGained += reinforcementsLeft / helldiversExtracted;
                pointsGained += helldiversExtracted;
            }
            else if (reinforcementsLeft == 0)
            {
                pointsGained += helldiversExtracted;
            }
            if (missionType == "Eradicate" || missionType == "Evacuate High-Value Assets")
            {
                pointsGained += 2;
            }

            if (shouldBeDoubled)
            {
                pointsGained *= 2;
            }

            if (isOperationCompleted && OperationType.SelectedItem.ToString() == "2 missions")
            {
                pointsGained += 3;
            }
            else if (isOperationCompleted && OperationType.SelectedItem.ToString() == "3 missions")
            {
                pointsGained += 5;
            }
           



            if (missionType == "Emergency Evacuation")
            {
                pointsGained -= civiliansKilled;
            }

            PointsGainLabel.Text = pointsGained.ToString();
        }



        private void SetControlsVisibility(bool isVisible)
        {
            MissionDifficultyBox.Visible = isVisible;
            SmallBaseBox.Visible = isVisible;
            MediumBaseBox.Visible = isVisible;
            BigBaseBox.Visible = isVisible;
            ReinforcementsLeftBox.Visible = isVisible;
            CommonSamplesText.Visible = isVisible;
            RareSamplesText.Visible = isVisible;
            SuperRareSamplesText.Visible = isVisible;
            HelldiversExtractedBox.Visible = isVisible;
            CompleteOperationYESNO.Visible = isVisible;
            BackpackYESNO.Visible = isVisible;
            SupportYESNO.Visible = isVisible;
            SaveButton.Visible = isVisible;
            label1.Visible = isVisible;
            label2.Visible = isVisible;
            label3.Visible = isVisible;
            label4.Visible = isVisible;
            label5.Visible = isVisible;
            label6.Visible = isVisible;
            label7.Visible = isVisible;
            label8.Visible = isVisible;
            label9.Visible = isVisible;
            label10.Visible = isVisible;
            label11.Visible = isVisible;
            label12.Visible = isVisible;
            PointsGainLabel.Visible = isVisible;

        }


        public void PopulateYesNoDropDowns()
        {
            var yesno = new List<string>
            {
                "Yes",
                "No"
            };
            foreach (var option in yesno)
            {
                CompleteOperationYESNO.Items.Add(option);
                BackpackYESNO.Items.Add(option);
                SupportYESNO.Items.Add(option);
            }

            OperationType.Items.Add("2 missions");
            OperationType.Items.Add("3 missions");
        }





        private void SmallBaseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SmallBaseBox.SelectedIndex != -1)
            {
                smallBase = SmallBaseBox.SelectedIndex;
                RecalculatePoints();
            }
        }

        private void MediumBaseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MediumBaseBox.SelectedIndex != -1)
            {
                mediumBase = MediumBaseBox.SelectedIndex;
                RecalculatePoints();
            }
        }

        private void BigBaseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BigBaseBox.SelectedIndex != -1)
            {
                bigBase = BigBaseBox.SelectedIndex;
                RecalculatePoints();
            }
        }

        private void CommonSamplesText_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(CommonSamplesText.Text, out commonSamples))
            {
                if (commonSamples >= 0 && commonSamples < 70)
                {
                    pointsFromCommonSamples = commonSamples;
                }
                else
                {
                    CommonSamplesText.Text = "";
                    pointsFromCommonSamples = 0;
                }
                RecalculatePoints();
            }
            else
            {
                CommonSamplesText.Text = "";
                pointsFromCommonSamples = 0;
            }
        }

        private void RareSamplesText_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(RareSamplesText.Text, out rareSamples))
            {
                if (rareSamples >= 0 && rareSamples < 70)
                {
                    pointsFromRareSamples = rareSamples;
                }
                else
                {
                    RareSamplesText.Text = "";
                    pointsFromRareSamples = 0;
                }
                RecalculatePoints();
            }
            else
            {
                RareSamplesText.Text = "";
                pointsFromRareSamples = 0;
            }
        }

        private void SuperRareSamplesText_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(SuperRareSamplesText.Text, out superRareSamples))
            {
                if (superRareSamples >= 0 && superRareSamples < 15)
                {
                    pointsFromSuperRareSamples = superRareSamples;
                }
                else
                {
                    SuperRareSamplesText.Text = "";
                    pointsFromSuperRareSamples = 0;
                }
            }
            else
            {
                SuperRareSamplesText.Text = "";
                pointsFromSuperRareSamples = 0;
            }

            RecalculatePoints();
        }


        private void RecalculatePoints()
        {
            pointsFromSmallBase = smallBase;
            pointsFromMediumBase = mediumBase * 2;
            pointsFromBigBase = bigBase * 3;
            pointsFromCommonSamples = commonSamples;
            pointsFromRareSamples = rareSamples;
            pointsFromSuperRareSamples = superRareSamples;
            pointsFromOperation = isOperationCompleted ? 2 : 0;
            pointsFromBackpack = isBackpackExtracted ? 1 : 0;
            pointsFromExtractedCivilians = helldiversExtracted;

            pointsLostFromCiviliansKilled = civiliansKilled;

            CalculatePoints();
        }
        private void MissionTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            missionType = MissionTypeBox.SelectedItem.ToString();
            shouldBeDoubled = missionType == "Eradicate" || missionType == "Evacuate High-Value Assets";
            if (missionType == "Emergency Evacuation")
            {
                ShowCiviliansLabels(true);
            }
            else
            {
                ShowCiviliansLabels(false);
            }
            SetControlsVisibility(true);
            RecalculatePoints();
        }

        private void ShowCiviliansLabels(bool show)
        {
            CiviliansKilledLabel.Visible = show;
            CiviliansKilledBox.Visible = show;
        }

        private void MissionDifficultyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MissionDifficultyBox.SelectedIndex != -1)
            {
                missionDifficulty = MissionDifficultyBox.SelectedIndex;
                if (missionDifficulty > 0 && missionDifficulty <= 3)
                {
                    pointsGainedForDifficulty = 1;
                }
                else if (missionDifficulty > 3 && missionDifficulty <= 6)
                {
                    pointsGainedForDifficulty = 3;
                }
                else if (missionDifficulty > 6 && missionDifficulty <= 9)
                {
                    pointsGainedForDifficulty = 5;
                }
                RecalculatePoints();
            }
        }
        private void PopulateMissionDifficulty()
        {
            for (int i = 1; i <= 9; i++)
            {
                MissionDifficultyBox.Items.Add(i.ToString());
            }
        }

        private void PopulateMissionTypes()
        {
            var missionTypes = new List<string>
    {
        "Eradicate",
        "Evacuate High-Value Assets",
        "Emergency Evacuation",
        "other"
    };

            foreach (var type in missionTypes)
            {
                MissionTypeBox.Items.Add(type);
            }
        }

        private void PopulateBaseSizes()
        {

            var smallBases = new List<string>();
            for (int i = 0; i <= 6; i++)
            {
                smallBases.Add(i.ToString());
            }
            var mediumBases = new List<string>();
            for (int i = 0; i <= 5; i++)
            {
                mediumBases.Add(i.ToString());
            }
            var bigBases = new List<string>();
            for (int i = 0; i <= 4; i++)
            {
                bigBases.Add(i.ToString());
            }
            foreach (var size in bigBases)
            {
                BigBaseBox.Items.Add(size);
            }
            foreach (var size in mediumBases)
            {
                MediumBaseBox.Items.Add(size);
            }
            foreach (var size in smallBases)
            {
                SmallBaseBox.Items.Add(size);
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CompleteOperationYESNO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CompleteOperationYESNO.SelectedIndex != -1)
            {
                isOperationCompleted = CompleteOperationYESNO.SelectedItem.ToString() == "Yes";
            }
            if (isOperationCompleted)
            {
                OperationType.Enabled = true;
                OperationType.Visible = true;
            }
            else
            {
                OperationType.Enabled = false;
                OperationType.Visible = false;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (isOperationCompleted)
            {
                if (OperationType.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select an operation type");
                    return;
                }
            }
            if (BackpackYESNO.SelectedIndex == -1)
            {
                MessageBox.Show("Please select if backpack was extracted");
                return;
            }
            if (SupportYESNO.SelectedIndex == -1)
            {
                MessageBox.Show("Please select if support weapon was extracted");
                return;
            }
            if (MissionTypeBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a mission type");
                return;
            }
            if (MissionDifficultyBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a mission difficulty");
                return;
            }
            if (SmallBaseBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the number of small bases");
                return;
            }
            if (MediumBaseBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the number of medium bases");
                return;
            }
            if (BigBaseBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the number of big bases");
                return;
            }
            if (ReinforcementsLeftBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter the number of reinforcements available");
                return;
            }
            if (CommonSamplesText.Text.Length == 0)
            {
                MessageBox.Show("Please enter the number of common samples");
                return;
            }
            if (RareSamplesText.Text.Length == 0)
            {
                MessageBox.Show("Please enter the number of rare samples");
                return;
            }
            if (SuperRareSamplesText.Text.Length == 0)
            {
                MessageBox.Show("Please enter the number of super rare samples");
                return;
            }
            if (HelldiversExtractedBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter the number of helldivers extracted");
                return;
            }

            if (CiviliansKilledBox.Text.Length == 0 && CiviliansKilledBox.IsAccessible)
            {
                MessageBox.Show("Please enter the number of civilians killed");
                return;
            }
            if (isBackpackExtracted && backpackCountBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter the number of backpacks extracted");
                return;
            }
            parentForm.currentPoints += pointsGained;
            this.Close();
        }


        private void HelldiversExtractedBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HelldiversExtractedBox.Text.Length > 0)
            {
                int value;
                if (int.TryParse(HelldiversExtractedBox.Text, out value))
                {
                    if (value < 0 || value > 30)
                    {
                        HelldiversExtractedBox.Text = "";
                    }
                    else
                    {
                        helldiversExtracted = int.Parse(HelldiversExtractedBox.Text);
                    }
                }
            }

        }




        private void CiviliansKilledBox_TextChanged(object sender, EventArgs e)
        {
            if (pointsLostFromCiviliansKilled > 0)
            {
                pointsGained += pointsLostFromCiviliansKilled;
                PointsGainLabel.Text = pointsGained.ToString();
                pointsLostFromCiviliansKilled = 0;
            }
            if (CiviliansKilledBox.Text.Length > 0)
            {
                int value;
                if (int.TryParse(CiviliansKilledBox.Text, out value))
                {
                    if (value < 0 || value > 30)
                    {
                        CiviliansKilledBox.Text = "";
                    }
                    else
                    {
                        civiliansKilled = int.Parse(CiviliansKilledBox.Text);
                    }
                    if (civiliansKilled > 0)
                    {
                        pointsLostFromCiviliansKilled = civiliansKilled;
                        pointsGained -= pointsLostFromCiviliansKilled;
                    }
                    PointsGainLabel.Text = pointsGained.ToString();
                }
            }

        }

        private void BackpackYESNO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BackpackYESNO.SelectedIndex != -1)
            {
                isBackpackExtracted = BackpackYESNO.SelectedItem.ToString() == "Yes";
            }
            if (isBackpackExtracted)
            {
                backpackLabel.Visible = true;
                backpackCountBox.Visible = true;
            }

        }

        private void SupportYESNO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SupportYESNO.SelectedIndex != -1)
            {
                isSupportWeaponExtracted = SupportYESNO.SelectedItem.ToString() == "Yes";
            }
            if (isSupportWeaponExtracted)
            {
                pointsGained += 1;
                PointsGainLabel.Text = pointsGained.ToString();
            }
        }

        private void OperationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (OperationType.SelectedItem.ToString())
            {
                case "2 missions":
                    pointsGained -= pointsFromOperation; // Subtract previously added points from operation
                    pointsFromOperation = 3; // Update points from operation
                    pointsGained += pointsFromOperation; // Add new points
                    break;
                case "3 missions":
                    pointsGained -= pointsFromOperation; // Subtract previously added points from operation
                    pointsFromOperation = 5; // Update points from operation
                    pointsGained += pointsFromOperation; // Add new points
                    break;
            }
            PointsGainLabel.Text = pointsGained.ToString();
        }

        private void backpackCountBox_TextChanged(object sender, EventArgs e)
        {
            if (backpackCountBox.Text.Length > 0)
            {
                int value;
                if (int.TryParse(backpackCountBox.Text, out value))
                {
                    if (value < 0 || value > 4)
                    {
                        backpackCountBox.Text = "";
                    }
                    else
                    {
                        pointsGained -= pointsFromBackpack; // Subtract previously added points
                        pointsFromBackpack = int.Parse(backpackCountBox.Text); // Update points from backpack
                        pointsGained += pointsFromBackpack; // Add new points
                    }
                }
            }
            PointsGainLabel.Text = pointsGained.ToString();
        }

        private void ReinforcementsLeftBox_TextChanged(object sender, EventArgs e)
        {
            if (ReinforcementsLeftBox.Text.Length > 0)
            {
                int value;
                if (int.TryParse(ReinforcementsLeftBox.Text, out value))
                {
                    if (value < 0 || value > 24)
                    {
                        ReinforcementsLeftBox.Text = "";
                    }
                    else
                    {
                        reinforcementsLeft = int.Parse(ReinforcementsLeftBox.Text);
                        CalculatePoints();
                    }
                }
            }
            PointsGainLabel.Text = pointsGained.ToString();

        }

        private void SupportYESNO_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (SupportYESNO.SelectedIndex != -1)
            {
                isSupportWeaponExtracted = SupportYESNO.SelectedItem.ToString() == "Yes";
            }
            if (isSupportWeaponExtracted)
            {
                countOfSupportWeaponsBox.Visible = true;
                supportWeaponLabel.Visible = true;
            }
            else
            {
                countOfSupportWeaponsBox.Visible = false;
                supportWeaponLabel.Visible = false;
            }
        }

        private void countOfSupportWeaponsBox_TextChanged(object sender, EventArgs e)
        {
            if (countOfSupportWeaponsBox.Text.Length > 0)
            {
                int value;
                if (int.TryParse(countOfSupportWeaponsBox.Text, out value))
                {
                    if (value < 0 || value > 4)
                    {
                        countOfSupportWeaponsBox.Text = "";
                    }
                    else
                    {
                        pointsFromSupportWeapons = int.Parse(countOfSupportWeaponsBox.Text); // Update points from backpack
                        CalculatePoints();
                    }
                }
            }
            PointsGainLabel.Text = pointsGained.ToString();

        }

        private void HelldiversExtractedBox_TextChanged(object sender, EventArgs e)
        {
            if (HelldiversExtractedBox.Text.Length > 0)
            {
                int value;
                if (int.TryParse(HelldiversExtractedBox.Text, out value))
                {
                    if (value < 0 || value > 4)
                    {
                        HelldiversExtractedBox.Text = "";
                    }
                    else
                    {
                        helldiversExtracted = int.Parse(HelldiversExtractedBox.Text);
                        CalculatePoints();
                    }
                }
            }
            PointsGainLabel.Text = pointsGained.ToString();

        }

        private void CompleteOperationYESNO_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CompleteOperationYESNO.SelectedIndex != -1)
            {
                isOperationCompleted = CompleteOperationYESNO.SelectedItem.ToString() == "Yes";
            }
            if (isOperationCompleted)
            {
                OperationType.Enabled = true;
                OperationType.Visible = true;
            }
            else
            {
                OperationType.Enabled = false;
                OperationType.Visible = false;
            }
        }

        private void OperationType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (OperationType.SelectedIndex != -1)
            {
                CalculatePoints();
            }
        }

        private void BackpackYESNO_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (BackpackYESNO.SelectedIndex != -1)
            {
                isBackpackExtracted = BackpackYESNO.SelectedItem.ToString() == "Yes";
            }
            if (isBackpackExtracted)
            {
                backpackLabel.Visible = true;
                backpackCountBox.Visible = true;
            }
            else
            {
                backpackLabel.Visible = false;
                backpackCountBox.Visible = false;
            }

        }

        private void backpackCountBox_TextChanged_1(object sender, EventArgs e)
        {
            if (backpackCountBox.Text.Length > 0)
            {
                int value;
                if (int.TryParse(backpackCountBox.Text, out value))
                {
                    if (value < 0 || value > 4)
                    {
                        backpackCountBox.Text = "";
                    }
                    else
                    {
                        pointsGained -= pointsFromBackpack; // Subtract previously added points
                        pointsFromBackpack = int.Parse(backpackCountBox.Text); // Update points from backpack
                        CalculatePoints();
                    }
                }
            }
            PointsGainLabel.Text = pointsGained.ToString();

        }

    }
}
