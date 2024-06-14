using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAS
{
    public class Mission
    {
        public int BasePoints { get; set; }
        public int SurvivingReinforcements { get; set; }
        public int CommonSamples { get; set; }
        public int RareSamples { get; set; }
        public int SuperSamples { get; set; }
        public int EvacuatedCivilians { get; set; }
        public int KilledCivilians { get; set; }
        public bool IsMissionSuccess { get; set; }
        public int MissionLevel { get; set; }
        public bool IsEradicateEnemy { get; set; }
        public bool IsRetrievePersonnel { get; set; }
        public bool IsEvacuateAssets { get; set; }
        public int Players { get; set; }

        public int CalculateTotalPoints()
        {
            if (!IsMissionSuccess) return 0;

            int totalPoints = BasePoints;

            // Additional points for samples
            totalPoints += CommonSamples / 10;
            totalPoints += RareSamples / 5;
            totalPoints += SuperSamples / 2;

            // Points for surviving reinforcements
            totalPoints += SurvivingReinforcements / Players;

            // Points for evacuated civilians
            if (IsRetrievePersonnel)
            {
                totalPoints += EvacuatedCivilians / 10;
            }

            // Penalty for killed civilians
            totalPoints -= KilledCivilians;

            // Apply doubling and additional points based on mission type
            if (IsEradicateEnemy || IsEvacuateAssets)
            {
                totalPoints *= 2;
                totalPoints += 2; // Additional points for specific missions
            }

            if (IsRetrievePersonnel)
            {
                totalPoints *= 2; // Double points for Retrieve Personnel missions
            }

            return totalPoints;
        }
    }
}
