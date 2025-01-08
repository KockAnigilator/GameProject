using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Игровые_механики
{
    public class GameHelper
    {


        public Character Player { get; set; }
        public Enemy Monster { get; set; }



        public GameHelper(Character player, Enemy monster)
        {
            Player = player;
            Monster = monster;
        }

        public void StartBattle()
        {
            Console.WriteLine("Начинается бой!");
            while (Player.Health > 0 && Monster.Health > 0)
            {
                BattleSystem.PerformAttack(Player, Monster);
                if (Monster.Health > 0)
                {
                    BattleSystem.PerformAttack(Monster, Player);
                }
            }

            if (Player.Health > 0)
            {
                Console.WriteLine("Вы победили монстра!");
            }
            else
            {
                Console.WriteLine("Вы погибли...");
            }
        }
    }
}
