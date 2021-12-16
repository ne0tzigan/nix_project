using System;

namespace DnD_Charlist.BLL
{
    public class BackgroundBLL
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public List<AbilityBLL> Abilities { get; set; }
    }
}
