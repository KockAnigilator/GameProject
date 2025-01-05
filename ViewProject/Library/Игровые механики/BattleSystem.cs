using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Игровые_механики
{
    public class BattleSystem
    {
        public static int CalculateDamage(Character attacker, Entity target)
        {
            Random rng = new Random();
            int baseDamage = attacker.Attack + attacker.Strength; // урон, это атака человека + его модификатор силы
            int criticalChance = rng.Next(100);

            // Критический удар
            if (criticalChance < attacker.Luck)
            {
                Console.WriteLine("Критический удар!");
                return baseDamage * 2;
            }

            // Урон с учетом защиты цели
            return Math.Max(0, baseDamage - target.Defense);
        }

        public static void PerformAttack(Character attacker, Entity target)
        {
            int damage = CalculateDamage(attacker, target);
            target.TakeDamage(damage);
            Console.WriteLine($"{attacker.Name} атакует {target.Name} и наносит {damage} урона!");
        }
    }
}
