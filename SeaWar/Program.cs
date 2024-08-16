using System;
using System.Diagnostics.Metrics;

namespace SeaWar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Давайте окунёмся в увлекательную игру.\n" +
                "Вам предстоит сразиться с морским флотом скуфов, удачи!");

            int[,] field = new int[10, 10];
            int counter = 0;
            Random rnd = new Random();


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (counter == 10) break;
                    field[i, j] = rnd.Next(0, 2);
                    if (field[i, j] == 1) counter++;
                }
            }
            counter = 0;
            while (counter < 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        ////if (field[i, j] == 1) 
                        //{
                        //    Console.Write(0);
                        //}
                        //else
                        {
                            Console.Write(field[i, j]);
                        }
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Введите координату по оси Х");
                int x = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите координату по оси У");
                int y = int.Parse(Console.ReadLine());

                if (x < 10 && y < 10 && x >= 0 && y >= 0)
                {
                    if (field[y, x] == 1)
                    {
                        field[x, y] = 2;
                        if (x + 1 < 10)
                            field[x + 1, y] = 2;
                        if (x + 1 < 10 && y + 1 < 10)
                            field[x + 1, y + 1] = 2;
                        if (y + 1 < 10)
                            field[x, y + 1] = 2;
                        if (x - 1 > -1 && y - 1 > -1)
                            field[x - 1, y - 1] = 2;
                        if (x - 1 > -1)
                            field[x - 1, y] = 2;
                        if (y - 1 > -1)
                            field[x, y - 1] = 2;
                        if (y - 1 > -1 && x + 1 < 10)
                            field[x + 1, y - 1] = 2;
                        if (x - 1 > -1 && y + 1 < 10)
                            field[x  - 1, y + 1] = 2;

                        counter++;

                        Console.WriteLine("Сбит корабль");
                    }

                }
                else if (field[y, x] == 0)
                {
                    Console.WriteLine("Попробуй снова :(");
                }
            }
            Console.WriteLine("Победа!!!");
        }
    }
}
