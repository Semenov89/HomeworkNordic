using System;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            //переменная для нумерации строк шахматной доски
            int count = 1;
            // константа, задающая размер поля
            const int size = 8;
            //сохранение цвета
            ConsoleColor saveColor = Console.BackgroundColor;

            //Формирование буквинной подписи сверху
            Console.Write($"");
            char c = 'A';
            for (int i = 0; i < size; i++)
            {
                Console.Write($" {c++,3}");
            }
            Console.WriteLine();

            // формирование поля двойного размера
            for (int f = 1; f <= size/2; f++)
            {
                //Формирование двойной строки, начиная с белого квадрата
                for (int i = 1; i <=2; i++)
                {
                    // формирование нумерации строк слева
                    Console.BackgroundColor=saveColor;
                    if (i%2 ==1)
                    {
                        Console.Write($"{count++,2}");
                    }
                    else
                    {
                        Console.BackgroundColor=saveColor;
                        Console.Write("  ");
                    }

                    for (int j = 1; j <=size/2; j++)
                    {

                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("    ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("    ");

                    }
                    // формирование нумерации строк справа
                    Console.BackgroundColor=saveColor;
                    if (i%2 ==1)
                    {
                        Console.Write(--count);
                    }

                    Console.WriteLine();

                }
                //Формирование двойной строки, начиная с черного квадрата
                for (int i = 1; i <=2; i++)
                {
                    // формирование нумерации строк слева
                    Console.BackgroundColor=saveColor;
                    if (i%2 ==1)
                    {
                        Console.Write($"{++count,2}");
                    }
                    else
                    {
                        Console.BackgroundColor=saveColor;
                        Console.Write("  ");
                    }

                    for (int j = 1; j <=size/2; j++)
                    {

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("    ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("    ");

                    }
                    // формирование нумерации строк справа
                    Console.BackgroundColor=saveColor;
                    if (i%2 ==1)
                    {
                        Console.Write(count++);
                    }
                    Console.WriteLine();
                }
            }
            //Формирование буквенной подписи, низ
            Console.BackgroundColor=saveColor;
            c='A';
            for (int i = 0; i < size; i++)
            {
                Console.Write($" {c++,3}");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }

}



