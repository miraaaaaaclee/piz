﻿int[,] t = {
                {-8,-14,-19,-18},
                { 25,28, 26, 20},
                { 11,18, 20, 25}
                };
//Задание 1.1
Console.WriteLine($"2 метеостанция 4 день: {t[1, 3]}, 3 метеостанция 1 день: {t[2, 0]}");
//Задание 1.2
Console.WriteLine("Температура всех метеостанций в течение 2 дня:");
for (int j = 0; j < t.GetLength(0); j++)
{
    Console.Write($"{t[j, 1]}  ");
}
//Задание 1.3
Console.WriteLine();
Console.WriteLine("Температура всех станций за все дни:");
for (int i = 0; i < t.GetLength(0); i++)
{
    for (int j = 0; j < t.GetLength(1); j++)
    {
        Console.Write($"{t[i, j]} ");
    }
    Console.WriteLine();
}
//Задание 1.4
int sum = 0;
for (int j = 0; j <= t.GetLength(0); j++)
{
    sum += t[2, j];
}
Console.WriteLine($"Средняя температура на 3 метеостанции: " + sum / 4);
//Задание 1.5
for (int i = 0; i < t.GetLength(0); i++)
{
    for (int j = 0; j < t.GetLength(1); j++)
    {
        if (t[i, j] >= 24 && t[i, j] <= 26)
        {
            Console.WriteLine($"Станция {i + 1} день {j + 1}");
        }
    }
}
Console.WriteLine();
//Задание 2
Console.WriteLine("Введите элементы массива:");
int[,] vasitit = new int[2, 3];
int sum2 = 0;
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 3; j++)
    {
        vasitit[i, j] = int.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < vasitit.GetLength(0); i++)
{
    for (int j = 0; j < vasitit.GetLength(1); j++)
    {
        sum2 += vasitit[i, j];
    }
}
Console.WriteLine($"Сумма элементов: {sum2}");
//Задание 3
Console.WriteLine("Введите элементы массива: ");
int[,] titivas = new int[4, 3];
int sum3 = 0;
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        titivas[i, j] = int.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < titivas.GetLength(0); i++)
{
    for (int j = 0; j < titivas.GetLength(1); j++)
    {
        if (titivas[i, j] >= 0)
        {
            sum3++;
        }
    }
}
Console.WriteLine($"количество положительных: {sum3}");
//Задание 4
Console.WriteLine("введите кол-во строк");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("введите кол-во столбцов");
int columns = int.Parse(Console.ReadLine());
int[,] visitat = new int[rows, columns];
int minValue = -15;
int maxValue = 15;
int min = int.MaxValue;
int max = int.MinValue;

FillMatrix(visitat, minValue, maxValue);
FindMinMaxArr(visitat, ref min, ref max);
Console.WriteLine($"Минимальный элемент: {min}, максимальный: {max}");
//Задание 5
int[,] yabloko = new int[5, 5];
FillMatrix(yabloko, -15, 15);
PlaceZero(yabloko);
PrintMatrix(yabloko);
Console.WriteLine();
//Задание 6
int[,] bulka = new int[3, 4];
FillMatrix(bulka, -15, 15);
int product;
Console.WriteLine("Введите столбец: ");
int m = int.Parse(Console.ReadLine());
FindProductOfColumn(bulka, m, out product);
Console.WriteLine($"Произведение элементов столбца: {product}");
//Задание 7
Console.WriteLine("Введите размерность матрицы: ");
m = int.Parse(Console.ReadLine());
int[,] cucumber = new int[m, m];
FillMatrix(cucumber, -15, 15);
Console.WriteLine("Произведение элементов главной диагонали: " + FindDiagonal(cucumber));

 static void FillMatrix(int[,] matrix, int minValue, int maxValue)
{
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(minValue, maxValue);
            Console.Write(matrix[i, j].ToString().PadLeft(4));
        }
        Console.WriteLine();
    }

}

 static void FindMinMaxArr(int[,] matrix, ref int min, ref int max)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > max && matrix[i, j] != 0) { max = matrix[i, j]; }
            if (matrix[i, j] < min && matrix[i, j] != 0) { min = matrix[i, j]; }
        }
    }
}

static void PlaceZero(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[0, i] = 0;
            matrix[4, i] = 0;
            matrix[i, 0] = 0;
            matrix[i, 4] = 0;
        }
        Console.WriteLine();
    }
}

static void PrintMatrix(int[,] m)
{
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
        {
            Console.Write(m[i, j].ToString().PadLeft(4));
        }
        Console.WriteLine();
    }
}
static void FindProductOfColumn(int[,] bulka, int M, out int product)
{
    product = 1;
    for (int i = 0; i < bulka.GetLength(0); i++)
        for (int j = 0; j < bulka.GetLength(1); j++)
        {
            if (j == M)
            {
                product = product * bulka[i, j];
            }
        }
}

static int FindDiagonal(int[,] cucumber)
{
    int product = 1;
    for (int i = 0; i < cucumber.GetLength(0); i++)
        for (int j = 0; j < cucumber.GetLength(1); j++)
        {
            if (i == j)
            {
                product = product * cucumber[i, j];
            }
        }

    return product;
}
