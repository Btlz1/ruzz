﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Net.WebSockets;
using System.Diagnostics.Contracts;


namespace похуй
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComputerClub computerClub = new ComputerClub(8);
            computerClub.Work();


        }
    }

    class ComputerClub
    {
        private int _money = 0;
        private List<Computer> _computers = new List<Computer>();
        public Queue<Client> _clients = new Queue<Client>();

        public ComputerClub(int computersCount)
        {
            Random random = new Random();

            for (int i = 0; i < computersCount; i++)
            {
                _computers.Add(new Computer(random.Next(5, 15)));
            }

            CreateNewClients(25, random);
        }
        public void CreateNewClients(int count, Random random)
        {
            for (int i = 0; i < count; i++)
            {
                _clients.Enqueue(new Client(random.Next(100, 250), random));
            }
        }
        public void Work()
        {
            while (_clients.Count > 0)
            {
                Client newClient = _clients.Dequeue();
                Console.WriteLine($"\nБаланс Клуба: {_money} Rub.\n");
                Console.WriteLine($"У вас новый клиент, он хочет купить {newClient.DesiredMinutes} минут.");
                ShowAllComputersState();

                Console.Write("\nВы предлагаете ему компьютер под номером:  ");
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int computerNumber))
                {
                    computerNumber -= 1;
                    if (computerNumber >= 0 && computerNumber < _computers.Count)
                    {
                        if (_computers[computerNumber].IsTaken)
                        {
                            Console.WriteLine("Этот комп занят. Клиент съебал");
                        }
                        else
                        {
                            if (newClient.CheckSolvency(_computers[computerNumber]))
                            {
                                Console.WriteLine("Клиент сел за компьтер номер " + (computerNumber + 1));
                                _money += newClient.Pay();
                                _computers[computerNumber].BecomeTaken(newClient);
                            }
                            else
                            {
                                Console.WriteLine("У клиента нет денег. Он ушел");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Вы сами не знаете за какой компьтер посадить клиента. Клиент съебался!");
                    }
                }
                else
                {
                    CreateNewClients(1, new Random());
                    Console.WriteLine("Неверный ввод! Повторите снова.");
                }

                Console.WriteLine("Чтобы перейти к следующему клиенту, нажмите любую клавишу...");
                Console.ReadKey();
                Console.Clear();
                SpendOneMinute();
            }
        }
        private void ShowAllComputersState()
        {
            Console.WriteLine("\nСписок всех компьютеров:");
            for (int i = 0; i < _computers.Count; i++)
            {
                Console.Write(i + 1 + " - ");
                _computers[i].ShowState();
            }
        }
        private void SpendOneMinute()
        {
            foreach (var computer in _computers)
            {
                computer.SpendOneMinute();
            }
        }
    }
    class Computer
    {
        private Client _client;
        private int _minutesRemaining;
        public bool IsTaken
        {
            get
            {
                return _minutesRemaining > 0;
            }
        }
        public int PricePerMinute { get; private set; }

        public Computer(int pricePerMinute)
        {
            PricePerMinute = pricePerMinute;
        }

        public void BecomeTaken(Client clien)
        {
            _client = clien;
            _minutesRemaining = _client.DesiredMinutes;
        }
        public void BecomeEmpty()
        {
            _client = null;
        }
        public void SpendOneMinute()
        {
            _minutesRemaining--;
        }
        public void ShowState()
        {
            if (IsTaken)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"Компьютер занят, осталось минут:  {_minutesRemaining}.");
                Console.BackgroundColor = ConsoleColor.Black;
            }

            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine($"Компьютер свободен, цена за 1 минуту: {PricePerMinute}.");
                Console.BackgroundColor = ConsoleColor.Black;
            }

        }
    }
    class Client
    {
        private int _money;
        private int _moneyToPay;
        public int DesiredMinutes { get; private set; }
        public Client(int money, Random random)
        {
            _money = money;
            DesiredMinutes = random.Next(10, 30);
        }
        public bool CheckSolvency(Computer computer)
        {
            _moneyToPay = DesiredMinutes * computer.PricePerMinute;
            if (_money >= _moneyToPay)
            {
                return true;
            }
            else
            {
                _moneyToPay = 0;
                return false;
            }
        }
        public int Pay()
        {
            _money -= _moneyToPay;
            return _moneyToPay;

        }
    }
}
