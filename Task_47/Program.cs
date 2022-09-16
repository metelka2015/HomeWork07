// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
// m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

double [,] CreatArrayWithRandomNumbers(int m, int n)
{
   double[,] result = new double[m, n];
    var random = new Random();
    for (m = 0; m < result.GetLength(0); m++)
    {
        for (n = 0; n < result.GetLength(1); n++)
        {
            result[m, n] = random.Next(-10,10);
        }
    }
    return result;
}

void PrintArray (double [,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}, ");
        }        
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число строк(m)");
if (!int.TryParse(Console.ReadLine()!, out var m)) {
    Console.WriteLine("Введено не целое число или не число");
}

Console.WriteLine("Введите число столбцов(n)");
if (!int.TryParse(Console.ReadLine()!, out var n)) {
    Console.WriteLine("Введено не целое число или не число");
}

PrintArray(CreatArrayWithRandomNumbers(m,n));