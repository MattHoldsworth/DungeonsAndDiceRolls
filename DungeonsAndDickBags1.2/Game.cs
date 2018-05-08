using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDickBags1._2
{
    public class Game
    {
        public Player player;
        public ArrayList playerData = new ArrayList();
        public ArrayList saves = new ArrayList();
        public QuestOne questOne;

        public Game()
        {
            player = new Player();
            player.NameSelect();
            player.ClassSelect();
            player.SetClass();
            questOne = new QuestOne();
            questOne.roundOne();
            questOne.roundTwo();

        }

        public void SaveData()
        {
            //for (var i = 0; i < Str.Length; i++)
            //    Str.Length + i;
            //Str = i;

            //var adding;
            //***********CONSIDER CHANGING THE ARRAY TO A LIST AND HOPE IT WORKS WITH WRITEALLLINES**********
            //Array.add(Str, Console.ReadLine());
            //System.IO.File.WriteAllLines(@"C:\Users\clret\OneDrive\Documents\DADBSaveFile.txt", Str);
        }

        public void EndGame()
        {
            Environment.Exit(0);
        }

    }
}
