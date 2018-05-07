using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDickBags1._2
{
    class Saves
    {

    }

    class Dialogue
    {
        Program program = new Program();
        public Dice dice = new Dice();
        //public String[] Str = new string[] { "" , "" };
        public List<Saves> saves = new List<Saves>();

        void SaveData()
        {
            //for (var i = 0; i < Str.Length; i++)
            //for (var i = 0; i < Str.Length; i++)
            //    Str.Length + i;
            //Str = i;

            //var adding;
            //***********CONSIDER CHANGING THE ARRAY TO A LIST AND HOPE IT WORKS WITH WRITEALLLINES**********
            Array.add(Str, Console.ReadLine());
            System.IO.File.WriteAllLines(@"C:\Users\clret\OneDrive\Documents\DADBSaveFile.txt", Str);
        }

        public void RollProcess(int numberOfSides, int stat, int DC)
        {
            dice.Die(numberOfSides);
            //DC stands for "Dice Challenge" - the number you compare your roll against
            Console.WriteLine(dice.rollResult + " + " + stat + " = " + " " + (dice.rollResult + stat) + " vs DC" + DC);
        }

        public void Conversation(string convo)
        {
            Console.WriteLine(convo);
            SaveData();
        }

        public void Choice(string situation, string choice1, string choice2, string choice3)
        {
            Console.WriteLine(situation + "\n1:" + choice1 + "\n2:" + choice2 + "\n3:" + choice3);
        }

        public void Outcome(string text)
        {
            Console.WriteLine(text);
        }

        public void Invalid()
        {
            Console.WriteLine("Invalid selection");
        }
    }
}
