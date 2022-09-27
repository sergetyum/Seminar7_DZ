// Задача 47. Задайте двумерный массив размером m×n, заполненный
// случайными вещественными числами.

// Задаем размерность массива.
Console.WriteLine("Задайте размер двумерного массива.");
Console.Write("Введите количество строк m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int n = int.Parse (Console.ReadLine());

// Задаем min и max значения массива.
Console.Write("Задайте min значение массива: ");
int min = int.Parse (Console.ReadLine());
Console.Write("Задайте max значение массива: ");
int max = int.Parse (Console.ReadLine());

// Объявляем двумерный массив.
double[,] matrix = new double[m,n];

// C помощью генератора случайных чисел заполняем массив случайными
// вещественными числами.
void FillArray (double[,] matrix)
{
    for (int i=0; i<m; i++)
    {
       for (int j=0; j<n; j++)
       {
       matrix[i,j] = new Random().Next(min,max) + Math.Round(new Random().NextDouble(), 1);
       }
    }
}

// Печатаем матрицу.
void PrintArray (double[,] matrix)
{
    for (int i=0; i<m; i++)
    {
    for (int j=0; j<n; j++)
    {
    Console.Write ($"{matrix[i,j]}{" "}");
    }
    Console.WriteLine();
    }
}
FillArray (matrix);
Console.Write($"m={m}, n={n}");
Console.WriteLine();
PrintArray (matrix);