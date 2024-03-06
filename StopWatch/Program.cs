 using System;
using System.Reflection.Metadata;
using System.Threading;

namespace StopWatch
 {
     class Program
     {
         static void Main(string[] args)
         {
            Menu();
         }

         static void Menu()
         {
            Console.Clear();
            Console.WriteLine("======= Seja bem-vindo ao seu StopWatch =======");
            Console.WriteLine();
            Console.WriteLine("S = Segundos => (Ex: 10s = 10 segundos)");
            Console.WriteLine();
            Console.WriteLine("M = Minutos => (Ex: 1m = 1 minuto)");
            Console.WriteLine();
            Console.WriteLine("0 = Sair");
            Console.WriteLine();
            Console.WriteLine("=========== Quanto tempo deseja contar? =======");
            Console.WriteLine();

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length-1,1));
            int time = int.Parse(data.Substring(0,data.Length-1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            PreStarter(time * multiplier);


         }

         static void PreStarter(int time)
         {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Go...");
            Thread.Sleep(2500);
            Console.Clear();

            Start(time);

         }

         static void Start( int time)
         {
             int currentTime = 0;

             while(currentTime != time)
             {
                 Console.Clear();
                 currentTime ++;
                 Console.WriteLine("==== StopWatch ====");
                 Console.WriteLine(currentTime);
                 Thread.Sleep(1000);
             }

             Console.Clear();
             Console.WriteLine("StopWatch Finalizado!!!");
             Thread.Sleep(2500);
         }
     }
 }

