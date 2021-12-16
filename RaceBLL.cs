using System;
using System.Collections.Generic;

namespace DnD_Charlist.BLL
{
    public class RaceBLL
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public List<AbilityBLL> Abilities { get; set; }
    }
}
