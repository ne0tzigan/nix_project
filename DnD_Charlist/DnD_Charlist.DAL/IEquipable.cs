using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnD_Charlist.DAL
{
    interface IEquipable
    {
        public Character EquippedOn { get; set; }
        public bool Equipped { get; set; }
    }
}
