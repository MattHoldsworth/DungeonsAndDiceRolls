using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDickBags1._2
{
    public class QuestOne
    {
        public Dice dice;
        public Dialogue dialogue;
        private bool fail = false;

        public QuestOne()
        {
            dice = new Dice();
            dialogue = new Dialogue();
        }

        public void roundOne()
        {
            dialogue.situation = "You find yourself behind steel bars. What do you do?";
            dialogue.optionOne = "Bend the bars with your might[STR]";
            dialogue.optionTwo = "Pick the lock with a bobby pin you found [DEX]";
            dialogue.optionThree = "Pretend to be sick until the guard has your attention [INT]";

            do
            {
                dialogue.Choice();
                try
                {
                    var firstChoice = int.Parse(Console.ReadLine());
                    if (firstChoice < 1 || firstChoice > 3)
                    {
                        fail = true;
                    } else
                    {
                        fail = false;
                    }

                    switch (firstChoice)
                    {
                        case 1:
                            dice.RollProcess(20, Player.characterSheet.STR, 15);

                            if (dice.rollResult + Player.characterSheet.STR >= 15)
                            {
                                Console.WriteLine("You bend the bar");
                            }
                            else
                            {
                                Console.WriteLine("You don't bend the bar");
                            }
                            break;
                        case 2:
                            dice.RollProcess(20, Player.characterSheet.REF, 15);

                            if (dice.rollResult + Player.characterSheet.REF >= 15)
                            {
                                Console.WriteLine("You pick the lock");
                            }
                            else
                            {
                                Console.WriteLine("You don't pick the lock");
                            }
                            break;
                        case 3:
                            dice.RollProcess(20, Player.characterSheet.INT, 15);

                            if (dice.rollResult + Player.characterSheet.INT >= 15)
                            {
                                Console.WriteLine("The guard falls for your trick and unlocks the cell door");
                            }
                            else
                            {
                                Console.WriteLine("The guard doesn't buy your shit");
                            }
                            break;
                    }
                }
                catch
                {
                    dialogue.Invalid();
                }
            } while (!fail);
        }

        public void roundTwo()
        {
            dialogue.situation = "After escaping your cell you realize you have to deal with the guard";
            dialogue.optionOne = "I punch the guard in the head";
            dialogue.optionTwo = "I quickly evade the guards incoming attack and snap his neck";
            dialogue.optionThree = "'Sleep' (cast sleep spell)";
            dialogue.Choice();
            var firstChoice = int.Parse(Console.ReadLine());
            Console.WriteLine("You selected " + firstChoice);
        }
    }
}
