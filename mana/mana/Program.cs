using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 5, maxHealth = 10;
            int mana = 7; int maxMana = 10;
            while (true)
            {
                DrawBar(health, maxHealth, ConsoleColor.Green, 0, '|');
                DrawBar(mana, maxMana, ConsoleColor.Blue, 1);

                Console.SetCursorPosition(0, 5);
                Console.WriteLine("введите число на которое измениться здоровье: ");
                health += Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите число на которое измениться мана: ");
                mana += Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }

        }
        static void DrawBar(int value, int maxValue, ConsoleColor color, int possition, char symbol = '/')
        {
            ConsoleColor defaultColor = Console.BackgroundColor;

            string bar = "";
            for (int i = 0; i < value; i++)
            {
                bar += symbol;
            }
            Console.SetCursorPosition(0, possition);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;

            bar = "";

            for (int i = value; i < maxValue; i++)
            {
                bar += " ";
            }
            Console.WriteLine(bar + "]");
        }
    }
}
