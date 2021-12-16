using System;

namespace DnD_Charlist.DAL
{
    public class Weapon : Equipment, IEquipable
    {
        public bool Equipped { get; set; }
        public Character EquippedOn { get; set; }
        public enum equipmentSlot
        {
            Natural=0,
            OneHanded=1,
            TwoHanded=3,
            Universal=2
        }
        public equipmentSlot EquipmentSlot { get; set; }
        int DamageDice;
        int DiceQuantity;
        string Modifier;
    }
}
