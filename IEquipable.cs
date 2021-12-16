using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DND_Charlist
{
    interface IEquipable
    {
        public Character EquippedOn { get; set; }
        public bool Equipped { get; set; }
    }
}
