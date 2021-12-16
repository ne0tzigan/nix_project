using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DnD_Charlist.DAL
{
    public class Accessory:Equipment,IEquipable
    {
        public Character EquippedOn { get; set; }
        [Required] 
        public bool Equipped { get; set; }
        public Effect Effect { get; set; }
    }
}
