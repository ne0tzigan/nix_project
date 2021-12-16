using System;

namespace DnD_Charlist.BLL
{
    public class ActiveAbilityBLL : AbilityBLL
    {
        public int Charges { get { return charges; } set { if (value > maxCharges) charges = maxCharges; } }
        public int charges;
        public int maxCharges;
    }
}
