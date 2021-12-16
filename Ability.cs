using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DND_Charlist
{
    public class Ability
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Desc { get; set; }
        public int Die { get; set; }
        public int DiceCount { get; set; }
        public int Modifier { get; set; }
    }

    public class ActiveAbility : Ability
    {
        public int Charges { get { return charges; } set { if (value > MaxCharges) charges = MaxCharges; } }
        private int charges;
        public int MaxCharges { get; set; }
    }

    public class Spell : Ability
    {
        public int Level { get; set; }
    }
}
