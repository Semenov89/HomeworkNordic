using System;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            // константа, задающая размер поля
            int size = 8;

            // формирование поля
            for (int i = 1; i <=size; i++)
            {
                for (int j = 1; j <=size/2; j++)
                {
                    if (i % 2 == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("  ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("  ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();

            }

            Console.ReadKey();
        }
    }
}



