using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DND_Charlist
{
    public class Character
    {
        Race race;
        Class[] classes;
        short int[] levels;
        Armor[] Armor { get; set; }
        Weapon[] Weapons { get; set; }
        Ability[] Abilities { get; set; }
    }
}
