using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnD_Charlist.BLL
{
    public class CharacterBLL
    {
        public int HitPoints;
        public readonly RaceBLL Race;
        public readonly BackgroundBLL Background;
        public ClassBLL[] Classes;
        public int[] Levels;
        public List<string> SavingThrowProficiency { get; set; }
        public List<SkillCheckBLL> SkillCheckProficiency { get; set; }
        public int SkillCheckModifier(SkillCheckBLL skill)
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
        public List<ArmorBLL> Armor { get; set; }
        public List<WeaponBLL> Weapons { get; set; }
        public List<AccessoryBLL> Accessories { get; set; }
        public List<AbilityBLL> Abilities
        {
            get
            {
                List<AbilityBLL> res=new List<AbilityBLL>();
                res.AddRange(abilities);
                res.Union(Race.Abilities);
                res.Union(Background.Abilities);
                int i = 0;
                foreach (ClassBLL @class in Classes){
                    res.Union(@class[Levels[i]]);
                    i++;
                }
                return res;
            }
            set { abilities = value; }
        }
        private List<AbilityBLL> abilities;
    }
}
