using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library
{
    public class Character : Entity
    {

        public Character(string name, int health, int attack, int defense, int strength, int dexterity, int intelligence, int wisdom, int charisma, int constitution, int luck, int level, int experience) : base(name, health, attack, defense)
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
            Wisdom = wisdom;
            Charisma = charisma;
            Constitution = constitution;
            Luck = luck;
        }

        public int Strength { get; set; }      // Сила
        public int Dexterity { get; set; }    // Ловкость
        public int Intelligence { get; set; } // Интеллект
        public int Wisdom { get; set; }       // Мудрость
        public int Charisma { get; set; }     // Харизма
        public int Constitution { get; set; } // Телосложение
        public int Luck { get; set; }         // Удача

        public override void PerformAction(Entity target)
        {
            Console.WriteLine($"{Name} атакует {target.Name}!");
            target.TakeDamage(Attack);
        }
    }
}
