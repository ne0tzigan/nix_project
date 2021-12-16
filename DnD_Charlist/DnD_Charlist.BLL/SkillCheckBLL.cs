using System;

namespace DnD_Charlist.BLL
{
	public class SkillCheckBLL
	{
		public string Name { get; set; }
		public string Modifier
		{
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
		public string modifier;
	}
}
