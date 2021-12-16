using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DnD_Charlist.DAL;

namespace DnD_Charlist.BLL
{
    public class AccessoryBLL:EquipmentBLL
    {
        public CharacterBLL EquippedOn { get; set; }
        [Required] 
        public bool Equipped { get; set; }
        public EffectBLL Effect { get; set; }
    }
}
