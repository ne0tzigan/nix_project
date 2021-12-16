using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DND_Charlist
{
    abstract public class Equipment
    {
        public Equipment(int copper=0,int silver=0,int electrum=0, int gold=0,int platinum=0)
        {
            silver = copper / 10;
            copper %= 10;
            electrum = silver / 5;
            silver %= 5;
            gold = electrum / 2;
            electrum %= 2;
            platinum = gold/10;
            gold %= 10;
            cost = new int[] { copper, silver, electrum, gold, platinum};
        }
        public string Name { get; set; }
        public int[] cost;
        public string DisplayCost
        {
            get {
                string res="";
                if (cost[4] != 0) res += String.Format("{0} ПM ", cost[4]);
                if (cost[3] != 0) res += String.Format("{0} ЗM ", cost[3]);
                if (cost[2] != 0) res += String.Format("{0} ЭM ", cost[2]);
                if (cost[1] != 0) res += String.Format("{0} СM ", cost[1]);
                if (cost[0] != 0) res += String.Format("{0} МM ", cost[0]);
                return res; 
            }
        }
    }
}
