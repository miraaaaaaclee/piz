using System;
class MainClass
{
    /*zad_1*/
    /*static void Main(string[] args)
    {
        Console.WriteLine("Введите три числа");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        Perimeter(a, b, c);
    }
    static void Perimeter(int a, int b, int c)
    {
        int perim = a + b + c;
        Console.WriteLine($"Периметр: {perim}");
    }*/

    /*zad_2*/
    /*static void Main(string[] args)
    {
        Console.WriteLine("Введите три числа");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Периметр: " + Perimeter(a, b, c));
    }
    static int Perimeter(int a, int b, int c)
    {
        int perim = a + b + c;
        return perim;
    }*/

    /*zad_3*/
    /*static void Main(string[] args)
    {
        Console.WriteLine("Введите четыре числа");
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());
        Distance(x1,y1,x2,y2);
    }
    static void Distance(int x1, int y1, int x2, int y2)
    {
        double form = Math.Sqrt(Math.Pow(x2-x1, 2)+ Math.Pow(y2 - y1, 2));
        Console.WriteLine($"Расстояние: {form}");
    }*/

    /*zad_4*/
    /*static void Main(string[] args)
    {
        Console.WriteLine("Введите четыре числа");
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Периметр: " + Distance(x1, y1, x2, y2));
    }
    static double Distance(double x1, double y1, double x2, double y2)
    {
        double form = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return form;
    }*/

    /*zad_5*/
    /*static void Main(string[] args)
    {
        Console.WriteLine("Введите двухзначное число");
        int n = int.Parse(Console.ReadLine());
        ChangeDigits(n);
    }
    static void ChangeDigits(int n)
    {
        int m1 = n / 10;
        int m2 = n % 10;
        int sum = m2*10 + m1;
        Console.WriteLine(sum);
    }*/

    /*zad_6*/
    /*static void Main(string[] args)
    {
        Console.WriteLine("Введите два двухзначное число");
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Побитовая сумма чисел: " + BitwiseSum(n1, n2));
    }
    static int BitwiseSum(int n1, int n2)
    {
        int m1 = n1 / 10;
        int m2 = n2 / 10;
        int w1 = n1 % 10;
        int w2 = n2 % 10;
        int b = (w1 + w2)%10;
        int r = (m1 + m2) * 10 + b;
        return r;
    }*/

    /*zad_7*/
    /*static void Main(string[] args)
    {
        int pos = 0;
        int neg = 0; ;
        PosNegSeq(ref pos, ref neg);
    }
    static void PosNegSeq(ref int pos,ref  int neg)
    {
        int num = 0;
        do
        {
            num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                pos++;
            }
            else if(num < 0)
            {
                neg++;
            }
        }while(num!=0);
        Console.WriteLine($"Положительное: {pos}");
        Console.WriteLine($"Отрицательное: {neg}");
    }*/
}


