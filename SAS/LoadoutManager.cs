using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SAS
{
    public partial class LoadoutManager : Form
    {
        private SAS parentForm;
        private Item armor;
        private Item weaponPrimary;
        private Item weaponSecondary;
        private Item grenade;
        private Item stratagem1;
        private Item stratagem2;
        private Item stratagem3;
        private Item stratagem4;
        private Item booster;
        List<Item> weaponsPrimary = new List<Item>()
        {
            new Item("AR-23 Liberator", 0),

            // 1 cost weapons
            new Item("AR-23A Liberator", 1),
            new Item("BR-14 Adjudicator", 1),
            new Item("AR-61 Tenderizer", 1),
            new Item("AR-23P Liberator Penetrator", 1),
            new Item("AR-23C Liberator Concussive", 1),

            // 2 cost weapons
            new Item("SMG-72 Pummeler", 2),
            new Item("MP-98 Knight", 2),
            new Item("SMG-37 Defender", 2),
            new Item("CB-9 Exploding Crossbow", 2),

            // 3 cost weapons
            new Item("SG-8 Punisher", 3),
            new Item("SG-8S Slugger", 3),
            new Item("R-63 Diligence", 3),

            // 4 cost weapons
            new Item("SG-225 Breaker", 4),
            new Item("R-36 Eruptor", 4),
            new Item("R-63 CS Diligence Counter-Sniper", 4),
            new Item("LAS-5 Scythe", 4),

            // 5 cost weapons
            new Item("SG-225SP Breaker Spray&Pray", 5),
            new Item("JAR-5 Dominator", 5),
            new Item("ARC-12 Blitzer", 5),

            // 6 cost weapons
            new Item("LAS-16 Sickle", 6),
            new Item("PLAS-101 Purifier", 6),

            // 7 cost weapons
            new Item("SG-225IE Breaker Incendiary", 7),
            new Item("PLAS-1 Scorcher", 7),
            new Item("SG-8P Punisher Plasma", 7)
        };
        List<Item> weaponsSecondary = new List<Item>
        {
            // 0 cost weapons
            new Item("P-2 Peacemaker", 0),

            // 2 cost weapons
            new Item("SG-22 Bushwacker", 2),
            new Item("P-113 Verdict", 2),
            new Item("LAS-7 Dagger", 2),

            // 3 cost weapons
            new Item("P-19 Redeemer", 3),
            new Item("GP-31 Grenade Pistol", 3),

            // 4 cost weapons
            new Item("P-4 Senator", 4)
        };

        List<Item> grenades = new List<Item>
        {
            // 0 cost grenades
            new Item("G-12 High Explosive", 0),
            new Item("G-3 Smoke", 0),
            new Item("K-2 Throwing knives", 0),

            // 1 cost grenades
            new Item("G-6 Frag", 1),
            new Item("G-123 Thermite", 1),

            // 2 cost grenades
            new Item("G-10 Incendiary", 2),
            new Item("G-23 Stun", 2),

            // 3 cost grenades
            new Item("G-16 Impact", 3),
            new Item("G-13 Incendiary Impact", 3)
        };
        List<Item> armors = new List<Item>
        {
            new Item("B-01 Tactical", 0),
            new Item("Medium Armor", 3),
            new Item("Light Armor", 4),
            new Item("Heavy Armor", 5),
        };
        List<Item> allStratagems = new List<Item>
        { 
            // Offensive Stratagems
            new Item("Orbital Precision Strike", 0),
            new Item("Eagle Smoke Strike", 3),
            new Item("Orbital Smoke Strike", 3),
            new Item("Orbital Gatling Barrage", 4),
            new Item("Eagle Strafing Run", 4),
            new Item("Orbital Gas Strike", 4),
            new Item("Orbital Airburst Strike", 5),
            new Item("Eagle Naplam Strike", 5),
            new Item("Orbital EMS Strike", 5),
            new Item("Eagle 110MM Rocket Pods", 5),
            new Item("Eagle Airstrike", 6),
            new Item("Eagle Cluster Bomb", 6),
            new Item("Eagle 500KG Bomb", 6),
            new Item("Orbital Railcannon Strike", 6),
            new Item("Orbital Laser", 7),
            new Item("Orbital 120MM HE Barrage", 7),
            new Item("Orbital 380MM HE Barrage", 8),
            new Item("Orbital Walking Barrage", 8),

            // Equipment Stratagems
            new Item("Machine Gun", 0),
            new Item("Ballistic Shield Pack", 3),
            new Item("Stalwart", 4),
            new Item("Flamethrower", 4),
            new Item("Airburst Rocket Launcher", 4),
            new Item("Grenade Launcher", 4),
            new Item("APW-1 Anti-Material Rifle", 5),
            new Item("MG-206 Heavy Machine Gun", 5),
            new Item("Supply Pack", 5),
            new Item("Guard Dog", 5),
            new Item("Expendable Anti-Tank", 5),
            new Item("Lift-850 Jump Pack", 5),
            new Item("Autocannon", 6),
            new Item("Railgun", 6),
            new Item("Arc Thrower", 6),
            new Item("Laser Cannon", 6),
            new Item("Guard Dog Rover", 6),
            new Item("Recoilless Rifle", 6),
            new Item("Spear", 7),
            new Item("Shield Generator Pack", 8),
            new Item("Quasar Cannon", 8),
            new Item("Patriot Exosuit", 10),
            new Item("Emancipator Exosuit", 10),

            // Defensive Stratagems
            new Item("Anti-Personnel Minefield", 4),
            new Item("Incendiary Mines", 4),
            new Item("Machine Gun Sentry", 4),
            new Item("HMG Emplacement", 5),
            new Item("Shield Generator Relay", 5),
            new Item("Gatling Sentry", 5),
            new Item("Tesla Tower", 6),
            new Item("Mortar Sentry", 6),
            new Item("EMS Mortar Sentry", 6),
            new Item("Autocannon Sentry", 6),
            new Item("Rocket Sentry", 6)
        };
        List<Item> boosters = new List<Item>
        {
            // 3 Cost Boosters
            new Item("UAV Recon", 3),
            new Item("Motivational Shocks", 3),

            // 4 Cost Boosters
            new Item("Vitality Enhancement", 4),
            new Item("Stamina Enhancement", 4),
            new Item("Muscle Enhancement", 4),
            new Item("Expert Extraction Pilot", 4),

            // 5 Cost Boosters
            new Item("Increased Reinforcement Budget", 5),
            new Item("Flexible Reinforcement Budget", 5),

            // 6 Cost Boosters
            new Item("Hellpod Space Optimization", 6),
            new Item("Localization Confusion", 6)
        };

        public LoadoutManager(SAS parent)
        {
            this.BackgroundImage = Properties.Resources.helldiverslogo;
            InitializeComponent();
            LoadItemsIntoListBoxes();
            this.parentForm = parent;
        }
        
        private void LoadItemsIntoListBoxes()
        {
            // Assuming weaponsPrimary, weaponsSecondary, grenades, and armors lists are already populated

            // Clear existing items
            PrimaryBox.Items.Clear();
            SecondaryBox.Items.Clear();
            GrenadeBox.Items.Clear();
            ArmorBox.Items.Clear();
            FirstStratagem.Items.Clear();
            SecondStratagem.Items.Clear();
            ThirdStratagem.Items.Clear();
            FourthStratagem.Items.Clear();
            Booster.Items.Clear();
            // Add primary weapons
            foreach (var item in weaponsPrimary)
            {
                PrimaryBox.Items.Add(item);
            }

            // Add secondary weapons
            foreach (var item in weaponsSecondary)
            {
                SecondaryBox.Items.Add(item);
            }

            // Add grenades
            foreach (var item in grenades)
            {
                GrenadeBox.Items.Add(item);
            }

            // Add armors
            foreach (var item in armors)
            {
                ArmorBox.Items.Add(item);
            }
            foreach (var item in allStratagems)
            {
                FirstStratagem.Items.Add(item);
                SecondStratagem.Items.Add(item);
                ThirdStratagem.Items.Add(item);
                FourthStratagem.Items.Add(item);
            }
            foreach (var item in boosters)
            {
                Booster.Items.Add(item);
            }
        }
        private void ArmorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ArmorBox.SelectedItem != null)
            {
                armor = (Item)ArmorBox.SelectedItem;
            }
            if (armor != null && weaponPrimary != null && weaponSecondary != null && grenade != null && stratagem1 != null && stratagem2 != null && stratagem3 != null && stratagem4 != null && booster != null)
            {
                TotalCost.Text = "Current cost: " + (armor.cost + weaponPrimary.cost + weaponSecondary.cost + grenade.cost + stratagem1.cost + stratagem2.cost + stratagem3.cost + stratagem4.cost + booster.cost);
            }
        }

        private void PrimaryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PrimaryBox.SelectedItem != null)
            {
                weaponPrimary = (Item)PrimaryBox.SelectedItem;
            }
            if (armor != null && weaponPrimary != null && weaponSecondary != null && grenade != null && stratagem1 != null && stratagem2 != null && stratagem3 != null && stratagem4 != null && booster != null)
            {
                TotalCost.Text = "Current cost: " + (armor.cost + weaponPrimary.cost + weaponSecondary.cost + grenade.cost + stratagem1.cost + stratagem2.cost + stratagem3.cost + stratagem4.cost + booster.cost);
            }
        }

        private void SecondaryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SecondaryBox.SelectedItem != null)
            {
                weaponSecondary = (Item)SecondaryBox.SelectedItem;
            }
            if (armor != null && weaponPrimary != null && weaponSecondary != null && grenade != null && stratagem1 != null && stratagem2 != null && stratagem3 != null && stratagem4 != null && booster != null)
            {
                TotalCost.Text = "Current cost: " + (armor.cost + weaponPrimary.cost + weaponSecondary.cost + grenade.cost + stratagem1.cost + stratagem2.cost + stratagem3.cost + stratagem4.cost + booster.cost);
            }
        }

        private void GrenadeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GrenadeBox.SelectedItem != null)
            {
                grenade = (Item)GrenadeBox.SelectedItem;
            }
            if (armor != null && weaponPrimary != null && weaponSecondary != null && grenade != null && stratagem1 != null && stratagem2 != null && stratagem3 != null && stratagem4 != null && booster != null)
            {
                TotalCost.Text = "Current cost: " + (armor.cost + weaponPrimary.cost + weaponSecondary.cost + grenade.cost + stratagem1.cost + stratagem2.cost + stratagem3.cost + stratagem4.cost + booster.cost);
            }
        }

        private void FirstStratagem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FirstStratagem.SelectedItem != null)
            {
                stratagem1 = (Item)FirstStratagem.SelectedItem;
            }
            if (armor != null && weaponPrimary != null && weaponSecondary != null && grenade != null && stratagem1 != null && stratagem2 != null && stratagem3 != null && stratagem4 != null && booster != null)
            {
                TotalCost.Text = "Current cost: " + (armor.cost + weaponPrimary.cost + weaponSecondary.cost + grenade.cost + stratagem1.cost + stratagem2.cost + stratagem3.cost + stratagem4.cost + booster.cost);
            }

        }

        private void SecondStratagem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SecondStratagem.SelectedItem != null)
            {
                stratagem2 = (Item)SecondStratagem.SelectedItem;
            }
            if (armor != null && weaponPrimary != null && weaponSecondary != null && grenade != null && stratagem1 != null && stratagem2 != null && stratagem3 != null && stratagem4 != null && booster != null)
            {
                TotalCost.Text = "Current cost: " + (armor.cost + weaponPrimary.cost + weaponSecondary.cost + grenade.cost + stratagem1.cost + stratagem2.cost + stratagem3.cost + stratagem4.cost + booster.cost);
            }

        }

        private void ThirdStratagem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ThirdStratagem.SelectedItem != null)
            {
                stratagem3 = (Item)ThirdStratagem.SelectedItem;
            }
            if (armor != null && weaponPrimary != null && weaponSecondary != null && grenade != null && stratagem1 != null && stratagem2 != null && stratagem3 != null && stratagem4 != null && booster != null)
            {
                TotalCost.Text = "Current cost: " + (armor.cost + weaponPrimary.cost + weaponSecondary.cost + grenade.cost + stratagem1.cost + stratagem2.cost + stratagem3.cost + stratagem4.cost + booster.cost);
            }

        }

        private void FourthStratagem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FourthStratagem.SelectedItem != null)
            {
                stratagem4 = (Item)FourthStratagem.SelectedItem;
            }
            if (armor != null && weaponPrimary != null && weaponSecondary != null && grenade != null && stratagem1 != null && stratagem2 != null && stratagem3 != null && stratagem4 != null && booster != null)
            {
                TotalCost.Text = "Current cost: " + (armor.cost + weaponPrimary.cost + weaponSecondary.cost + grenade.cost + stratagem1.cost + stratagem2.cost + stratagem3.cost + stratagem4.cost + booster.cost);
            }

        }

        private void Booster_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Booster.SelectedItem != null)
            {
                booster = (Item)Booster.SelectedItem;
            }
            if (armor != null && weaponPrimary != null && weaponSecondary != null && grenade != null && stratagem1 != null && stratagem2 != null && stratagem3 != null && stratagem4 != null && booster != null)
            {
                TotalCost.Text = "Current cost: " + (armor.cost + weaponPrimary.cost + weaponSecondary.cost + grenade.cost + stratagem1.cost + stratagem2.cost + stratagem3.cost + stratagem4.cost + booster.cost);
            }
        }

        private void SaveLoadout_Click(object sender, EventArgs e)
        {
            if (armor != null && weaponPrimary != null && weaponSecondary != null && grenade != null && stratagem1 != null && stratagem2 != null && stratagem3 != null && stratagem4 != null && booster != null)
            {
                parentForm.UpdateCurrentPoints(armor.cost + weaponPrimary.cost + weaponSecondary.cost + grenade.cost + stratagem1.cost + stratagem2.cost + stratagem3.cost + stratagem4.cost + booster.cost);
                this.Close();
            }
        }
    }
}
