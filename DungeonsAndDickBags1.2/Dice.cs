using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDickBags1._2
{
    public class Dice
    {
        public int rollResult;

        Random roll = new Random();

        public int Die(int sides)
        {
            rollResult = roll.Next(1, (sides += 1));
            Console.WriteLine(rollResult);
            return rollResult;
        }
    }
}
