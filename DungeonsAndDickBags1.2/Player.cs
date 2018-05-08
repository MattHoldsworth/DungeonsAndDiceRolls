using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDickBags1._2
{
    public class Player
    {
        public static CharSheet characterSheet;
        public int selection;
        public string input;
        private bool check;

        public Player()
        {
            characterSheet = new CharSheet();
            input = "";
            selection = 0;
        }

        public void NameSelect()
        {
            input = "";
            do
            {
                Console.WriteLine("What is your name?");
                characterSheet.playerName = Console.ReadLine();

                Console.WriteLine("Are you sure? Y/N");
                input = Console.ReadLine();
            } while (input != "Y");

        }

        public void ClassSelect()
        {
            Console.WriteLine("Welcome " + characterSheet.playerName + ". ");
            input = "";
            do
            {
                do
                {
                    Console.WriteLine("Select a number to choose your class " +
                        "\n1: Warrior" +
                        "\n2: Wizard" +
                        "\n3: Rogue");
                    try
                    {
                        selection = int.Parse(Console.ReadLine());
                        check = true;
                        if (selection > 3 || selection < 1)
                        {
                            check = false;
                            Console.WriteLine("Invalid entry, please choose again.");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Invalid entry, please choose again.");
                    }
                } while (!check);
                Console.WriteLine("Are you happy with your selection? Y/N");
                input = Console.ReadLine();
            } while (input != "Y");
        }

        public void SetClass()
        {
            characterSheet.className = Enum.GetName(typeof(CharSheet.Classes), selection);

            switch (characterSheet.className)
            {
                case "warrior":
                    Warrior warrior = new Warrior();
                    characterSheet.STR = warrior.baseStr;
                    characterSheet.INT = warrior.baseInt;
                    characterSheet.REF = warrior.baseRef;
                    break;
                case "rogue":
                    Rogue rogue = new Rogue();
                    characterSheet.STR = rogue.baseStr;
                    characterSheet.INT = rogue.baseInt;
                    characterSheet.REF = rogue.baseRef;
                    break;
                case "wizard":
                    Wizard wizard = new Wizard();
                    characterSheet.STR = wizard.baseStr;
                    characterSheet.INT = wizard.baseInt;
                    characterSheet.REF = wizard.baseRef;
                    break;
            }
            Console.WriteLine("You have chosen to be a " + characterSheet.className);
        }
    }
}
