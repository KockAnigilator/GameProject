using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class Entity
    {
        /// <summary>
        /// Дефолтные статы в днд, у каждого героя будет защита, имя, здоровье
        /// </summary>
        public string name;
        public int health;
        public int defense;
        public int attack;

        //Инкапсуляция
        public string Name { get => name; set => name = value; }
        public int Health { get => health; set => health = value; }
        public int Defense { get => defense; set => defense = value; }
        public int Attack { get => attack; set => attack = value; }
        public int Luck { get; internal set; }
        public int Strength { get; internal set; }

        public Entity(string name, int health, int defense, int attack)
        {
            this.name = name;
            this.health = health;
            this.defense = defense;
            this.attack = attack;
        }

        public void TakeDamage(int damage)
        {
            int damageTaken = Math.Max(0, damage - Defense);
            Health -= damageTaken;
            Console.WriteLine($"{Name} получил {damageTaken} урона. Осталось здоровья: {Health}");
        }


        //Действия игрогов/противников
        public abstract void PerformAction(Entity target);


    }
}
