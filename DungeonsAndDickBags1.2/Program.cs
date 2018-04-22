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

            Console.WriteLine("What is your character name?");
            player.playerName = Console.ReadLine();

            void characterSelection()
            {
                Console.WriteLine("Welcome " + player.playerName + ". ");

                Console.WriteLine("Select a number to choose your class " +
                    "\n1: Warrior" +
                    "\n2: Wizard" +
                    "\n3: Rogue");
                var input = Console.ReadLine();
                var characterClass = Convert.ToInt32(input);

                switch (characterClass)
                {
                    case 1:
                        player.Warrior();
                        break;
                    case 2:
                        player.Wizard();
                        break;
                    case 3:
                        player.Rogue();
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        characterSelection();
                        break;
                }
            }
            characterSelection();

            void choiceOne()
            {

                Console.WriteLine("You find yourself behind steel bars. What do you do?" +
                    "\n1: Bend the bars with your might [STR]" +
                    "\n2: Pick the lock with a bobby pin you found [DEX]" +
                    "\n3: Pretend to be sick until the guard has your attention [INT]");

                var firstChoice = int.Parse(Console.ReadLine());

                switch (firstChoice)
                {
                    case 1:
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
                        break;
                    case 2:
                        dice.Die(20);
                        Console.WriteLine(dice.rollResult + " + " + player.REF + " = " + " " + (dice.rollResult + player.REF) + " vs DC15");

                        if (dice.rollResult + player.REF >= 15)
                        {
                            Console.WriteLine("You pick the lock");
                            choiceOne();
                        }
                        else
                        {
                            Console.WriteLine("You don't pick the lock");
                            choiceOne();
                        }
                        break;
                    case 3:
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
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        choiceOne();
                        break;
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
