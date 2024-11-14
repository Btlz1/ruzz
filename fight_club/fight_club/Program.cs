using System;
using System.Collections.Generic;
using System.Linq;

namespace похуй
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fighter[] fighters =
            {
                new Fighter ("Джон", 500, 50, 0),
                new Fighter ("Марк", 250, 25, 20),
                new Fighter ("Алекс", 150, 100, 10),
                new Fighter ("Джен", 300, 75, 5)
            };
            for (int i = 0; i < fighters.Length; i++)
            {
                Console.WriteLine(i + 1 + " ");
                fighters[i].ShowStats();
            }

            int fighterNumder;

            Console.WriteLine("\n** " + new string('_', 25) + " **");
            Console.WriteLine("\nВыберите номер первого бойца: ");
            fighterNumder = Convert.ToInt32(Console.ReadLine()) - 1;
            Fighter firstFighter = fighters[fighterNumder];

            Console.WriteLine("\nВыберите номер второго бойца: ");
            fighterNumder = Convert.ToInt32(Console.ReadLine()) - 1;
            Fighter secondFighter = fighters[fighterNumder];
            Console.WriteLine("\n** " + new string('_', 25) + " **");

            while (firstFighter.Health > 0 && secondFighter.Health > 0)
            {
                firstFighter.TakeDamage(secondFighter.Damage);
                secondFighter.TakeDamage(firstFighter.Damage);
                firstFighter.ShowCurrentHealth();
                secondFighter.ShowCurrentHealth();
            }
            if (firstFighter.Health <= 0 && secondFighter.Health <= 0)
            {
                Console.WriteLine("Ничья! Оба бойца пали в бою.");
            }
            else if (firstFighter.Health <= 0)
            {
                Console.WriteLine($"{secondFighter.Name} победил!");
            }
            else
            {
                Console.WriteLine($"{firstFighter.Name} победил!");
            }

            Console.ReadKey();
        }
    }
    class Fighter
    {
        private string _name;
        private int _health;
        private int _damage;
        private int _armor;
        public string Name
        {
            get { return _name; }
        }
        public int Health
        {
            get { return _health; }
        }
        public int Damage
        {
            get { return _damage; }
        }



        public Fighter(string name, int health, int damage, int armor)
        {
            _name = name;
            _health = health;
            _damage = damage;
            _armor = armor;
        }
        public void ShowStats()
        {
            Console.WriteLine($"Боец - {_name} \nЗдоровье:{_health}\nУрон: {_damage}\nБроня: {_armor}");
        }
        public void ShowCurrentHealth()
        {
            Console.WriteLine($"{_name} здоровье: {_health}.");
        }
        public void TakeDamage(int damage)
        {
            _health -= damage - _armor;
        }

    }
}
