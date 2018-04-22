using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDickBags1._2
{
    class Program
    {
        static CharSheet player = new CharSheet();

        static void Main(string[] args)
        {
            Dice dice = new Dice();
            
            /* ********EDIT OUT LATER*************
            //stats
            var STR = 0;
            var DEX = 0;
            var INT = 0;
            */

            Console.WriteLine("What is your character name?");
            player.playerName = Console.ReadLine();

            void characterSelection()
            {
                Console.WriteLine("Welcome " + player.playerName + ". ");

                Console.WriteLine("Select a number to choose your class \n1: Warrior\n2: Wizard\n3: Rogue");
                var input = Console.ReadLine();
                var characterClass = Convert.ToInt32(input);
                if (characterClass == 1)
                {
                    //warrior
                    player.STR = 8;
                    player.DEX = 4;
                    player.INT = 0;

                    Console.WriteLine(player.playerName + " the Warrior " + "Your stats are" + "\nSTR: " + player.STR + "\nDEX:" + player.DEX + "\nINT:" + player.INT);
                }
                else if (characterClass == 2)
                {
                    //wizard
                    player.STR = 0;
                    player.DEX = 2;
                    player.INT = 10;

                    Console.WriteLine(player.playerName + " the Wizard " + "Your stats are" + "\nSTR: " + player.STR + "\nDEX:" + player.DEX + "\nINT:" + player.INT);
                }
                else if (characterClass == 3)
                {
                    //rogue
                    player.STR = 2;
                    player.DEX = 8;
                    player.INT = 4;

                    Console.WriteLine(player.playerName + " the Rogue " + "Your stats are" + "\nSTR: " + player.STR + "\nDEX:" + player.DEX + "\nINT:" + player.INT);
                }
                else if (characterClass >= 4 || characterClass <= 0)
                {
                    Console.WriteLine("Invalid number");
                    characterSelection();
                }
            }
            characterSelection();

            void choiceOne()
            {

                Console.WriteLine("You find yourself behind steel bars. What do you do?" +
                    "\n1: Bend the bars with your might [STR]" +
                    "\n2: Pick the lock with a bobby pin you found [DEX]" +
                    "\n3: Pretend to be sick until the guard has your attention [INT]");

                var input = Console.ReadLine();
                var firstChoice = Convert.ToInt32(input);

                if (firstChoice == 1)
                {
                    dice.Die(20);
                    Console.WriteLine(dice.rollResult + " + " + player.STR + " = " + " " + (dice.rollResult + player.STR) + " vs DC15");

                    if (dice.rollResult + player.STR >= 15)
                    {
                        Console.WriteLine("You bend the bar");
                        choiceTwo();
                    }
                    else
                    {
                        Console.WriteLine("You don't bend the bar");
                        choiceOne();
                    }
                }
                else if (firstChoice == 2)
                {
                    dice.Die(20);
                    Console.WriteLine(dice.rollResult + " + " + player.DEX + " = " + " " + (dice.rollResult + player.DEX) + " vs DC15");

                    if (dice.rollResult + player.DEX >= 15)
                    {
                        Console.WriteLine("You pick the lock");
                        choiceOne();
                    }
                    else
                    {
                        Console.WriteLine("You don't pick the lock");
                        choiceOne();
                    }
                }
                else if (firstChoice == 3)
                {
                    dice.Die(20);
                    Console.WriteLine(dice.rollResult + " + " + player.INT + " = " + " " + (dice.rollResult + player.INT) + " vs DC15");

                    if (dice.rollResult + player.INT >= 15)
                    {
                        Console.WriteLine("The guard falls for your trick and unlocks the cell door");
                        choiceOne();
                    }
                    else
                    {
                        Console.WriteLine("The guard doesn't buy your shit");
                        choiceOne();
                    }
                }
                else
                {
                    choiceOne();
                }
            }

            choiceOne();

            void choiceTwo()
            {
                Console.WriteLine("After escaping your cell you realize you have to deal with the guard" +
                    "\n1: I punch the guard in the head" +
                    "\n2: I quickly evade the guards incoming attack and snap his neck" +
                    "\n3: 'Sleep' (cast sleep spell)");
            }
            
        }
    }
}
