using System;
using System.Collections.Generic;

namespace DnD_Charlist.DAL
{
    public enum RaceSize
    {
        Tiny,
        Small,
        Medium,
        Large,
        Huge,
        Gargantuan
    }
    public class Race
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public RaceSize Size { get; set; } = RaceSize.Medium;
        public List<Ability> Abilities { get; set; }
    }
}
