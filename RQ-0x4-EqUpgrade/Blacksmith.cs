using System;

namespace RQ_0x4_EqUpgrade
{
    public class Blacksmith
    {
        const int MaxUpgradeLevel = 9;
        const int ExpectedUpgradeTreshold = 2;
        const float StatisticsMultiplier = 1.2F;

        Random upgradeProbability;

        public Blacksmith()
        {
            upgradeProbability = new Random();
        }

        public void Upgrade(ref IEquipment item)
        {
            if(item.Level < MaxUpgradeLevel && UpgradeSucceeded(item.Level))
            {
                item.Agility = UpgradeStat(item.Agility);
                item.Health = UpgradeStat(item.Health);
                item.Strength = UpgradeStat(item.Health);
                item.Wisdom = UpgradeStat(item.Wisdom);
                item.Level++;
            }
        }

        private float UpgradeStat(float stat)
        {
            return stat * StatisticsMultiplier;
        }

        private bool UpgradeSucceeded(int equipmentLevel)
        {
            int result = upgradeProbability.Next(0, equipmentLevel);
            int expected = equipmentLevel / ExpectedUpgradeTreshold;
            return expected == result;
        }
    }
}
