// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateArray(int m, int n)
{
    var random = new Random();
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = random.Next(1, 10);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

double ArithmeticAverage(int[,] array, int n)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    double average = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double summ = 0;

        for (int j = 0; j < array.GetLength(0); j++)
        {
            summ = summ + array[j, i];
        }
        average = summ / n;
        if (i < array.GetLength(1)-1)
        {            
            Console.Write($"{average.ToString("N1")}; ");
        }
        else
        {
            Console.Write($"{average.ToString("N1")}.");
        }
    }
    return average;
}

Console.WriteLine("Введите число строк(m)");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число столбцов(n)");
int n = int.Parse(Console.ReadLine());

Console.Clear();
var array = CreateArray(m, n);
PrintArray(array);
ArithmeticAverage(array, m);