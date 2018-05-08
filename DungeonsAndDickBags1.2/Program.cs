using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDickBags1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.SaveData();
            game.EndGame();
        }
    }
}
