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

        public static void PerformAttack(Entity attacker, Entity defender)
        {
            Random rng = new Random();
            int baseDamage = attacker.Attack + attacker.Strength / 2; // Урон на основе атаки и силы
            int criticalChance = rng.Next(100); // Критический шанс

            // Проверка на критический удар
            if (criticalChance < attacker.Luck)
            {
                baseDamage *= 2;
                Console.WriteLine($"{attacker.Name} наносит КРИТИЧЕСКИЙ удар!");
            }

            // Вычисление финального урона с учетом защиты
            int damage = Math.Max(0, baseDamage - defender.Defense);

            // Применение урона
            defender.TakeDamage(damage);

            // Вывод результата атаки
            Console.WriteLine($"{attacker.Name} атакует {defender.Name} и наносит {damage} урона!");
            if (defender.Health <= 0)
            {
                Console.WriteLine($"{defender.Name} побежден!");
            }
        }


    }
}
