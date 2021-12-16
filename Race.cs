﻿using System;
using System.Collections.Generic;

namespace DND_Charlist
{
    public enum RaceSize
    {
        Tiny,
        Small,
        Medium,
        Large,
        Huge,
        Gargantuan
    }
    public class Race
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public RaceSize Size { get; set; } = RaceSize.Medium;
        public List<Ability> Abilities { get; set; }
    }
    public class Background
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public List<Ability> Abilities { get; set; }
    }
}
