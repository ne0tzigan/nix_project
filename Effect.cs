using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DND_Charlist
{
    public struct Effect
    {
        public Effect(string name, string desc, string duration,bool curse=false)
        {
            Name = name;
            Description = desc;
            Duration = duration;
            isCursed = curse;
        }
        public string Name;
        public string Description;
        public string Duration;
        public bool isCursed;
    }
}
