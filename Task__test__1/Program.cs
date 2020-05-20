using System;

namespace Test__task__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n" + "  2D ARRAY" + "\n");
            Console.ResetColor();

            //Создаем рандомный массив 20 на 20
            int size = 20;
            int[,] arr = new int[size, size];
            Random r = new Random();

            //Находим в массиве наименьшее и наибольшее число и координаты 
            int max = 0;
            int min = 99;
            int ro = 0, c = 0, ro_m = 0, c_m = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    arr[i, j] = r.Next(10, 99);
                    if (i == j || i > j)
                        if (arr[i, j] > max)
                        {
                            max = arr[i, j];
                            ro = i;
                            c = j;
                        }

                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        ro_m = i;
                        c_m = j;
                    }

                    // Выводим массив на экран
                    Console.Write("{0,4}", arr[i, j]);
                }
                Console.WriteLine();
            }

            //Выводим наименьшее и наибольшее число и координаты
            Console.WriteLine("\n" + "  Max value: " + max + "\t\t" + "Coordinates: ({0}:{1})", ro, c);
            Console.WriteLine("\n" + "  Min value: " + min + "\t\t" + "Coordinates: ({0}:{1})", ro_m, c_m);

            //Сортеруем массив
            for (int k = 0; k < size; k++)
            {
                for (int l = 0; l < size; l++)
                {
                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            if (i + 1 == size && j + 1 == size)
                            {
                                continue;
                            }
                            else
                            {
                                if (j + 1 == size && arr[i, j] > arr[i + 1, 0])
                                {
                                    int t = arr[i, j];
                                    arr[i, j] = arr[i + 1, 0];
                                    arr[i + 1, 0] = t;
                                }
                                else
                                {
                                    if (j + 1 != size && arr[i, j] > arr[i, j + 1])
                                    {
                                        int t = arr[i, j];
                                        arr[i, j] = arr[i, j + 1];
                                        arr[i, j + 1] = t;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n" + "  SORTED 2D ARRAY" + "\n");
            Console.ResetColor();

            //Выводим отсортированный массив на экран
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0,4}", arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
