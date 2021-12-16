using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DND_Charlist
{
    public class Class
    {
        [Required]
        public string Name { get; set; }
        List<Ability>[] abilities;
        public int[] ProficiencyBonus = new int[20];
        public List<Ability> this[int i]
        {
            get 
            {
                List<Ability> res = new List<Ability>();
                for (int level = 1; level <= i; level++) res.AddRange(abilities[level]);
                return res;
            }
        }
        public readonly int HitDie;
    }
}
