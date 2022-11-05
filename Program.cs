using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome!");
            Thread.Sleep(1500);
            Console.Clear();
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Which function do you want to use?");
            Thread.Sleep(1000);
            Console.WriteLine("1 - Stopwatch");
            Console.WriteLine("2 - Timer");
            Console.WriteLine("3 - Exit");

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Select one of the options:");
            short answer = short.Parse(Console.ReadLine());

            switch (answer)
            {
                case 1: Stopwatch(); break;
                case 2: Timer(); break;
                case 3: Exit(); break;
                default: Menu(); break;
            }

        }
        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go!");
            Thread.Sleep(1500);
        }
        static void Selection()
        {
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("Do you want to return to the menu or exit the application??");
            Console.WriteLine("1 - Menu");
            Console.WriteLine("2 - Exit");
            short secondAnswer = short.Parse(Console.ReadLine());

            if (secondAnswer == 1)
            {
                Console.WriteLine("Returnig to menu.");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Welcome back.");
                Menu();
            }
            else
            {
                Exit();
            }
        }
        static void Stopwatch()
        {
            Console.Clear();
            Console.WriteLine("S = Seconds => 10s = 10 seconds");
            Console.WriteLine("M = Minuts => 1m = 1 minut");
            Console.WriteLine("--------------------");
            Console.WriteLine("How long do you want to count?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
            { multiplier = 60; }

            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);

            StartStopwatch(time);
        }
        static void StartStopwatch(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finished.");
            Thread.Sleep(2500);
            Selection();
        }
        static void Timer()
        {
            Console.Clear();
            Console.WriteLine("S = Seconds => 10s = 10 seconds");
            Console.WriteLine("M = Minuts => 1m = 1 minut");
            Console.WriteLine("--------------------");
            Console.WriteLine("How long do you want to count?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
            { multiplier = 60; }

            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);

            StartTimer(time);
        }
        static void StartTimer(int time)
        {
            int currentTime = time;

            while (currentTime != 0)
            {
                Console.Clear();
                Console.WriteLine(currentTime);
                currentTime--;
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finished.");
            Thread.Sleep(2500);
            Selection();
        }
        static void Exit()
        {
            Console.Clear();

            Console.WriteLine("Thank you for using our system. See you soon!");
            Thread.Sleep(1000);
            System.Environment.Exit(0);
        }
    }
}