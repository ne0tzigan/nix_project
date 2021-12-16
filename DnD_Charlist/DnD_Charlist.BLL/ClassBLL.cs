using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DnD_Charlist.BLL
{
    public class ClassBLL
    {
        [Required]
        public string Name { get; set; }
        List<AbilityBLL>[] abilities;
        public int[] ProficiencyBonus = new int[20];
        public List<AbilityBLL> this[int i]
        {
            get 
            {
                List<AbilityBLL> res = new List<AbilityBLL>();
                for (int level = 1; level <= i; level++) res.AddRange(abilities[level]);
                return res;
            }
        }
        public readonly int HitDie;
    }
}
