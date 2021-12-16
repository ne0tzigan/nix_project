using System;

namespace DnD_Charlist.DAL
{
    public class Background
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public List<Ability> Abilities { get; set; }
    }
}
