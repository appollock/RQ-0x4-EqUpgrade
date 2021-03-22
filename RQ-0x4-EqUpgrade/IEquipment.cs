using System;

namespace RQ_0x4_EqUpgrade
{
    public interface IEquipment
    {
        public int Level { get; set; }
        public float Strength { get; set; }
        public float Agility { get; set; }
        public float Wisdom { get; set; }
        public float Health { get; set; }
    }
}
