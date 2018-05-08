using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDickBags1._2
{
    public class CharSheet
    {
        public enum Classes { warrior = 1, rogue = 2, wizard = 3 };
        public string playerName { get; set; }
        public string className { get; set; }

        public string race;

        public int STR = 0;
        public int REF = 0;
        public int VIT = 0;
        public int INT = 0;
        public int CHA = 0;

        string weapon;

        public int Exp;

        public void ShowStats()
        {
            Console.WriteLine(playerName + " the " + className + ". Your stats are:" +
                "\nSTR: " + STR +
                "\nDEX:" + REF +
                "\nINT:" + INT);
        }

    }
}
