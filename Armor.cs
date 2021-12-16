using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DND_Charlist
{
    public class Armor : Equipment, IEquipable
    {

        public bool Equipped { get; set; }
        public Character EquippedOn { get; set; }
        public enum equipmentSlot
        {
            ArmorSet,
            Shield
        }
        public equipmentSlot EquipmentSlot { get; set; }
        int armorClass;
        string Modifier;
        public int ArmorClass()
        {
            return armorClass + (int)EquippedOn.Characteristics.Modifier(Modifier);
        }
    }
}
