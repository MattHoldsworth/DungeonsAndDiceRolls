using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDickBags1._2
{
    public class Dialogue
    {
        public string message;
        public string optionOne;
        public string optionTwo;
        public string optionThree;
        public string optionFour;
        public string optionFive;
        public string optionSix;
        public string optionSeven;
        public string situation;

        public void Choice()
        {
            Console.WriteLine(situation + "\n1:" + optionOne + "\n2:" + optionTwo + "\n3:" + optionThree);
        }

        public void Invalid()
        {
            Console.WriteLine("Invalid selection");
        }

        public void OutputMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
