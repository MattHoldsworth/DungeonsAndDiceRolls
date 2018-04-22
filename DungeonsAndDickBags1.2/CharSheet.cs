using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDickBags1._2
{
    class CharSheet
    {
        public string playerName;
        public string race;
        public string playerClass;

        public int STR, REF, VIT, INT, CHA; //Strength, Reflex, Vitality, Intelligence, Charm

        string weapon;

        public int Exp;

        public void ShowStats()
        {
            Console.WriteLine(playerName + " the " + playerClass + ". Your stats are:" +
                "\nSTR: " + STR +
                "\nDEX:" + REF +
                "\nINT:" + INT);
        }

        public void Warrior()
        {
            playerClass = "warrior";

            STR = 8;
            REF = 4;
            INT = 0;

            ShowStats();
        }

        public void Wizard()
        {
            playerClass = "wizard";

            STR = 0;
            REF = 2;
            INT = 10;

            ShowStats();
        }

        public void Rogue()
        {
            playerClass = "rogue";

            STR = 2;
            REF = 8;
            INT = 4;

            ShowStats();
        }
    }
}
