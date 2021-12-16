using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DnD_Charlist.BLL;

namespace DnD_Charlist.DAL
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
}
