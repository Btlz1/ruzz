using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Eventing.Reader;

namespace практика
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            Table[] tables = { new Table(1, 4), new Table(2, 8), new Table(3, 10) };
            while (isOpen)

            {
                Console.Clear();
                Console.WriteLine("Администрирование кафе:\n");
                for (int i = 0; i < tables.Length; i++)
                {
                    tables[i].ShowInfo();
                }

                Console.Write("Введите номер стола, который хотите забронировать: ");
                int wishTable = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.Write("Введите колличество мест, которые хотите забронировать: ");
                int disearedPlaces = Convert.ToInt32(Console.ReadLine());

                bool isReservationComplited = tables[wishTable].Reserve(disearedPlaces);

                if (isReservationComplited)
                {
                    Console.WriteLine("Бронь прошла успешно.");
                }
                else
                {
                    Console.WriteLine("Бронь не прошла. Недостаточно мест.");




                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        class Table
        {
            public int Number;
            public int MaxPlaces;
            public int FreePlaces;

            public Table(int number, int maxPlaces)
            {
                Number = number;
                MaxPlaces = maxPlaces;
                FreePlaces = maxPlaces;
            }
            public void ShowInfo()
            {
                Console.WriteLine($"Стол : {Number}, свободно мест: {FreePlaces} из {MaxPlaces}.");
            }
            public bool Reserve(int places)
            {
                if (FreePlaces >= places)
                {
                    FreePlaces -= places;
                    return true;
                }
                else { return false; }
            }
        }
    }
}

