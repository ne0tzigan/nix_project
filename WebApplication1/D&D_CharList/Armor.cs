using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DND_Charlist
{
    public class Armor : Equipment, IEquipable
    {
        public bool Weared { get; set; }
        override public enum EquipmentType
        {
            ArmorSet,
            Shield,
        }
        int ArmorClass;

    }
}
