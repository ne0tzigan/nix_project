using System;

namespace DnD_Charlist.DAL
{
    public class ActiveAbility : Ability
    {
        public int Charges { get { return charges; } set { if (value > maxCharges) charges = maxCharges; } }
        public int charges;
        public int maxCharges;
    }
}
