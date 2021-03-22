using System;

using System;

namespace RQ_0x4_EqUpgrade.Model
{
    public class Armor : IEquipment
    {
        public string Name { get; set; }
        public float ArmorValue { get; set; }

        public int Level { get; set; }
        public float Strength { get; set; }
        public float Agility { get; set; }
        public float Wisdom { get; set; }
        public float Health { get; set; }
    }
}
