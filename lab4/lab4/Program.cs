﻿/*задание_1*/
/*int counter1 = 3;
while (counter1 <= 21)
{
    Console.WriteLine(counter1);
    counter1 += 2;
}*/

/*int counter2 = 3;
do
{
    Console.WriteLine(counter2);
    counter2 += 2;
}
while (counter2 <= 21);*/

/*задание_2*/
/*int counter1 = 15;
while (counter1 >= 0)
{
    Console.WriteLine(counter1);
    counter1 -= 3;
}*/

/*int counter2 = 15;
do
{
    Console.WriteLine(counter2);
    counter2 -= 3;
}
while (counter2 >= 0);*/

/*задание_3*/
/*int counter1 = 10;
int umn = 10;
while (counter1 <= 20)
{
    counter1 += 2;
    Console.WriteLine(umn);
    umn *= counter1;
}*/

/*задание_4*/
/*double sum = 0;
double numb;
int m = 1;
while(m <= 5)
{
    numb = double.Parse(Console.ReadLine());
    sum += numb;
    Console.WriteLine(sum);
    m++;
}*/

/*задание_5*/
/*Console.WriteLine("Введите последовательность чисел и закончите ввод нулем");
int numb;
int nom = 0;
int max = int.MinValue;
try
{
    do
    {
        numb = Int32.Parse(Console.ReadLine());
        if (numb > max && numb != 0)
        {
            nom++;
            max = numb;
            
        }
    }
    while (numb != 0);
}
catch (FormatException e)
{
    Console.WriteLine(e.Message + " Повторите ввод");
}

Console.WriteLine($"максимальное значение {max}");
Console.WriteLine($"порядковый номер {nom}");*/

