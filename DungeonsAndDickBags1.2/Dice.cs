using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDickBags1._2
{
    public class Dice
    {
        //Dice dice = new Dice();

        public int rollResult;

        Random roll = new Random();

        public int Die(int sides)
        {
            rollResult = roll.Next(1, (sides += 1));
            return rollResult;
        }

        public void RollProcess(int numberOfSides, int stat, int DC)
        {
            Die(numberOfSides);
            //DC stands for "Dice Challenge" - the number you compare your roll against
            Console.WriteLine(rollResult + " + " + stat + " = " + " " + (rollResult + stat) + " vs DC" + DC);
        }
    }
}
