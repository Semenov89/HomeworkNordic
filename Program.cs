using System;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            // константа, задающая размер поля
            const int size = 8;

            // формирование поля двойного размера
            for (int f = 0; f < size/2; f++)
            {
                for (int i = 1; i <=2; i++)
                {
                    for (int j = 1; j <=size/2; j++)
                    {

                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("    ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("    ");

                    }

                    Console.WriteLine();

                }
                for (int i = 1; i <=2; i++)
                {
                    for (int j = 1; j <=size/2; j++)
                    {

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("    ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("    ");

                    }
                    Console.WriteLine();
                }
            }
            
            Console.ReadKey();
        }
    }
    
}



