using System;
using System.Reflection;

namespace DND_Charlist
{
	public struct Characteristics
	{
		public Characteristics(short strength=8,short agility=8,short constitution=8,short intelligence=8,short wisdom=8,short charisma=8)
        {
			Strength = strength;
			Agility = agility;
			Constitution = constitution;
			Intelligence = intelligence;
			Wisdom = wisdom;
			Charisma = charisma;
        }
		public int Strength;
		public int Agility;
		public int Constitution;
		public int Intelligence;
		public int Wisdom;
		public int Charisma;
		public int Modifier(string charName)
		{
			int res =10;
			switch(charName)
			{
				case "Strength":
				res = Strength;
				break;
				case "Agility":
				res=Agility;
				break;
				case "Constitution":
				res=Constitution;
				break;
				case "Intelligence":
				res = Intelligence;
				break;
				case "Wisdom":
				res=Wisdom;
				break;
				case "Charisma":
				res=Charisma;
				break;
			}
			res -= 10;
			res /= 2;
		return res;
		}
	}

	public class SkillCheck
    {
		public string Name { get; set; }
		public string Modifier {
			get
			{
				switch (modifier)
				{
					case "Strength":
					case "Agility":
					case "Constitution":
					case "Intelligence":
					case "Wisdom":
					case "Charisma":
						return modifier;
					default:
						return "Wisdom";
				}
			} 
			set { modifier = value; } 
		}
		private string modifier;
	}
}
