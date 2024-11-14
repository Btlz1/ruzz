using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace _2_попытка_пакман
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            char[,] map = ReadMap("Map.txt");
            ConsoleKeyInfo pressedKey = new ConsoleKeyInfo('w', ConsoleKey.W, false, false, false);

            Task.Run(() =>
            {
                while (true)
                {
                    pressedKey = Console.ReadKey();
                }
            });
            int pacmanX = 1;
            int pacmanY = 1;
            int score = 0;

            while (true)
            {
                Console.Clear();
                DrawMap(map);

                Console.SetCursorPosition(pacmanX, pacmanY);
                Console.Write("@");
                Console.SetCursorPosition(25, 0);
                Console.Write($"Score: {score}");

                HandleInput(pressedKey, ref pacmanX, ref pacmanY, map, ref score);
                Thread.Sleep(100);

            }
        }
        private static char[,] ReadMap(string path)
        {
            string[] file = File.ReadAllLines("Map.txt");

            int maxLength = MaxLenghtOfLine(file);

            char[,] map = new char[maxLength, file.Length];

            for (int y = 0; y < file.Length; y++)
            {
                for (int x = 0; x < maxLength; x++)
                {
                    if (x < file[y].Length)
                    {
                        map[x, y] = file[y][x];
                    }
                    else
                    {
                        map[x, y] = ' ';
                    }
                }
            }

            return map;
        }
        private static void DrawMap(char[,] map)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    Console.Write(map[x, y]);
                }
                Console.Write("\n");

            }



        }
        private static int MaxLenghtOfLine(string[] lines)
        {
            int maxLenght = lines[0].Length;
            foreach (var line in lines)
                if (line.Length > maxLenght)
                    maxLenght = line.Length;
            return maxLenght;


        }
        private static void HandleInput(ConsoleKeyInfo pressedKey, ref int pacmanX, ref int pacmanY, char[,] map, ref int score)
        {
            int[] dirrection = GetDirection(pressedKey);
            int nextPacmanPositionX = pacmanX + dirrection[0];
            int nextPacmanPositionY = pacmanY + dirrection[1];

            char nextCell = map[nextPacmanPositionX, nextPacmanPositionY];
            if (nextCell == ' ' || nextCell == '.')
            {
                pacmanX = nextPacmanPositionX;
                pacmanY = nextPacmanPositionY;
            }
            if (nextCell == '.')
            {
                score++;
                map[nextPacmanPositionX, nextPacmanPositionY] = ' ';
            }



        }
        private static int[] GetDirection(ConsoleKeyInfo pressedKey)
        {
            int[] dirrection = { 0, 0 };

            if (pressedKey.Key == ConsoleKey.UpArrow)
                dirrection[1] = -1;
            else if (pressedKey.Key == ConsoleKey.DownArrow)
                dirrection[1] = 1;
            else if (pressedKey.Key == ConsoleKey.LeftArrow)
                dirrection[0] = -1;
            else if (pressedKey.Key == ConsoleKey.RightArrow)
                dirrection[0] = 1;

            return dirrection;

        }
    }


}
