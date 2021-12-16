using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DnD_Charlist.BLL
{
    public class AbilityBLL
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Desc { get; set; }
        public int Die { get; set; }
        public int DiceCount { get; set; }
        public int Modifier { get; set; }
    }
}
