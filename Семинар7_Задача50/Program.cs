// Задача 50. Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.

// 1. Задаем параметры массива (размер, мин. и макс. значения).
Console.WriteLine("Задайте параметры двумерного массива.");
Console.Write("Введите количество строк m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int n = int.Parse (Console.ReadLine());
Console.Write("Задайте min значение массива: ");
int min = int.Parse (Console.ReadLine());
Console.Write("Задайте max значение массива: ");
int max = int.Parse (Console.ReadLine());

// 2. Задаем позицию искомого элемента (строка столбец). 
Console.WriteLine("Введите позицию элемента в формате (строка столбец).");
string position1Position2 = Console.ReadLine();
string[] pos1Pos2 = position1Position2.Split();
int position1 = int.Parse(pos1Pos2[0]);
int position2 = int.Parse(pos1Pos2[1]);

// 3. Объявляем двумерный массив.
int[,] matrix = new int[m,n];

// 4. Инициализируем массив с помощью генератора случайных чисел.
void FillArray (int[,] matrix)
{
    for (int i=0; i<m; i++)
    {
       for (int j=0; j<n; j++)
       {
       matrix[i,j] = new Random().Next(min,max);
       }
    }
}

// 5. Печатаем матрицу.
void PrintArray (int[,] matrix)
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

// 6. Проверяем позицию на наличие ее в массиве и выводим в терминал ее значение.
void Position (int[,] matrix)
{
   if (position1>m || position2>n)
   {
   Console.WriteLine($"Позиции {position1} {position2} в массиве нет.");
   }
   else
   {
   Console.WriteLine($"Значение позиции {position1} {position2} -> {matrix[position1-1, position2-1]}");
   }
}

// 7. Вызываем методы
FillArray (matrix);
Console.Write("Массив:");
Console.WriteLine();
PrintArray (matrix);
Position (matrix);