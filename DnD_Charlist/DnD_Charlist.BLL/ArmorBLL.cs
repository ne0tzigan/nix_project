namespace DnD_Charlist.BLL
{
    public class ArmorBLL : EquipmentBLL
    {

        public bool Equipped { get; set; }
        public CharacterBLL EquippedOn { get; set; }
        public enum equipmentSlot
        {
            ArmorSet,
            Shield
        }
        public equipmentSlot EquipmentSlot { get; set; }
        int armorClass;
        public string Modifier;
        public int ArmorClass()
        {
            return armorClass + (int)EquippedOn.Characteristics.Modifier(Modifier);
        }
    }
}
