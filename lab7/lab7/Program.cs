using System;

namespace lab7
{
    class lab7
    {
        /*zad_1*/

        /*static void Main(string[] args)
        {
            double[] arr = { 1.1, -2.3, 3.7, 4.1, 5.6, 6.1, 7.1 };
            Print(arr);
            FindMinMax(arr);
        }

        static void Print(double[] array) //Выводит массивчик
        {
            foreach (var i in array)
                Console.Write(i + " ");
            Console.WriteLine();
        }

        static void FindMinMax(double[] array) //Находим минимальное и максимальное значение массива
        {
            double max = double.MinValue;
            double min = double.MaxValue;
            foreach (var i in array)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            foreach (var i in array)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            Console.WriteLine($"Минимальное {min}, Максимальное {max}");
        }*/

        /*zad_2*/

        /*static void Main(string[] args)
        {
            int[] arr = new int[15];
            FillArray(arr);
            Print(arr);
            Console.WriteLine("введите число n");
            int n = int.Parse(Console.ReadLine());
            FindN(arr, n);
        }
        static void Print(int[] array)
        {
            foreach (var i in array) {
                Console.WriteLine(i + " ");
            }
        }
        static void FillArray(int[] arr)
        {
            Random r= new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(1,10);
            }
        }
        static void FindN(int[] arr, int n)
        {
            bool f = false;
            int counter = 0;
            int n_counter = 0;
            foreach(int i in arr)
            {
                if(i == n)
                {
                    f = true;
                    n_counter = counter;
                    break;
                }
                counter++;
            }
            if (f)
            {
                Console.WriteLine("Результат: да");
                Console.WriteLine($"Индекс: {n_counter}");
            }
            else
            {
                Console.WriteLine("Результат: нет");
            }
        }*/

        /*zad_3*/
        /*static void Main(string[] args)
        {
            double[] arr = new double[10];
            Console.WriteLine("Массив:");
            FillArray(arr);
            Console.WriteLine("Суммы троек:");
            Sum(arr);
        }
        static void FillArray(double[] arr)
        {
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.NextDouble() * 10 - 5;
            }
            foreach(var i in arr)
            {
                Console.WriteLine("{0:0.00} ", i);
            }
        }
        static void Sum(double[] arr)
        {
            double l = 0;
            for(int i = 0;i < arr.Length; i++)
            {
                try
                {
                    l = arr[i] + arr[i + 1] + arr[i + 2];
                }
                catch
                {
                    continue;
                }
                Console.WriteLine("{0:0.00}", l);
            }
        }*/
    }
}