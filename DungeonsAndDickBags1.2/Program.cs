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
            Dialogue dialogue = new Dialogue();

            dialogue.Conversation("What is your character name?");
            player.playerName = dialogue.Str[0];

            void characterSelection()
            {
                dialogue.Conversation("Welcome " + player.playerName + ". " +
                    "\n:Select a number to choose your class " +
                    "\n1: Warrior" +
                    "\n2: Wizard" +
                    "\n3: Rogue");
                /*
                Console.WriteLine("Welcome " + player.playerName + ". ");

                Console.WriteLine("Select a number to choose your class " +
                    "\n1: Warrior" +
                    "\n2: Wizard" +
                    "\n3: Rogue");
                */
                var characterClass = int.Parse(Console.ReadLine());

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
                        dialogue.Invalid();
                        characterSelection();
                        break;
                }
            }
            characterSelection();

            void choiceOne()
            {
                dialogue.Choice("You find yourself behind steel bars. What do you do?",
                    "Bend the bars with your might[STR]",
                    "Pick the lock with a bobby pin you found [DEX]",
                    "Pretend to be sick until the guard has your attention [INT]");

                var firstChoice = int.Parse(Console.ReadLine());

                switch (firstChoice)
                {
                    case 1:
                        dialogue.RollProcess(20, player.STR, 15);

                        if (dialogue.dice.rollResult + player.STR >= 15)
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
                        dialogue.RollProcess(20, player.REF, 15);

                        if (dialogue.dice.rollResult + player.REF >= 15)
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
                        dialogue.RollProcess(20, player.INT, 15);

                        if (dialogue.dice.rollResult + player.INT >= 15)
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
                        dialogue.Invalid();
                        choiceOne();
                        break;
                }
            }
            choiceOne();

            void choiceTwo()
            {
                dialogue.Choice("After escaping your cell you realize you have to deal with the guard",
                    "I punch the guard in the head",
                    "I quickly evade the guards incoming attack and snap his neck",
                    "'Sleep' (cast sleep spell)");
            }
            
        }
    }
}
