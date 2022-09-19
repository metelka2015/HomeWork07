// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int[,] CreateArray(int m, int n)
{
    var random = new Random();
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = random.Next(0, 10);
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

void CheckPosition(int[,] array, int m, int n, int a, int b)
{
    if (a > m | b > n)
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine($"\nОтвет: {array[a-1, b-1]}");
    }
}


Console.Clear();

Console.WriteLine("Введите число строк(m)");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число столбцов(n)");
int n = int.Parse(Console.ReadLine());

var result = CreateArray(m, n);
PrintArray(result);

Console.WriteLine("Введите номер строки");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите номер столбца");
int b = int.Parse(Console.ReadLine());

CheckPosition(result, m, n, a, b);



