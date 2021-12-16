using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnD_Charlist.DAL
{
    public class Character
    {
        public int HitPoints;
        public readonly Race Race;
        public readonly Background Background;
        public Class[] Classes;
        public int[] Levels;
        public List<string> SavingThrowProficiency { get; set; }
        public List<SkillCheck> SkillCheckProficiency { get; set; }
        public int SkillCheckModifier(SkillCheck skill)
        {
            int res = this.Characteristics.Modifier(skill.Modifier);
            if (this.SkillCheckProficiency.Contains(skill))
            {
                int max=Classes[0].ProficiencyBonus[Levels[0]];
                for(int i=1; i<Levels.Length; i++)
                {
                    if (Classes[i].ProficiencyBonus[Levels[i]] > max);
                }
                res += max;
            }
            return res;
        }
        public Characteristics Characteristics { get; set; }
        public List<Armor> Armor { get; set; }
        public List<Weapon> Weapons { get; set; }
        public List<Accessory> Accessories { get; set; }
        public List<Ability> Abilities
        {
            get
            {
                List<Ability> res=new List<Ability>();
                res.AddRange(abilities);
                res.Union(Race.Abilities);
                res.Union(Background.Abilities);
                int i = 0;
                foreach (Class @class in Classes){
                    res.Union(@class[Levels[i]]);
                    i++;
                }
                return res;
            }
            set { abilities = value; }
        }
        private List<Ability> abilities;
    }
}
