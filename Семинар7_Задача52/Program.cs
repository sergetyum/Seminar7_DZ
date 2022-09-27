// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// 1. Задаем двумерный массив из целых чисел.
Console.WriteLine("Задайте параметры двумерного массива.");
Console.Write("Введите количество строк m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int n = int.Parse (Console.ReadLine());
Console.Write("Задайте min значение массива: ");
int min = int.Parse (Console.ReadLine());
Console.Write("Задайте max значение массива: ");
int max = int.Parse (Console.ReadLine());

// 2. Объявляем двумерный массив.
int[,] matrix = new int[m,n];

// 3. Инициализируем массив с помощью генератора случайных чисел.
void FillArray (int[,] matrix)
{
    for (int i=0; i<m; i++)
    {
       for (int j=0; j<n; j++)
       {
       matrix[i,j] = new Random().Next(min,max+1); //не забываем, что Next не включаем второе число, поэтому +1
       }
    }
}

// 4. Печатаем матрицу.
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

// 5. Вызываем методы
FillArray (matrix);
Console.Write("Массив:");
Console.WriteLine();
PrintArray (matrix);

// 6. Находим среднее арифметическое элементов в каждом столбце.
double[] averageArithmeticOfColumn = new double [n]; //объявляем массив average для коллекции средн. арифм. значений
for (int j=0; j<n; j++) //цикл по столбцам
{
    double summaOfColumn = 0; //объявляем тип и первоначальное значение суммы столбца
    for (int i = 0; i < m; i++) // цикл по строкам
    {
    summaOfColumn += matrix[i,j]; //сумма столбца
    }
    averageArithmeticOfColumn[j] = Math.Round(summaOfColumn / m, 1); // среднее арифметическое j столбца 
}

//7. Печатаем средние арифметические значения столбцов.
Console.WriteLine("Среднее арифметическое каждого столбца: ");
for (int j = 0; j < n; j++) // цикл по столбцам
Console.Write(averageArithmeticOfColumn[j] + " "); // вывод среднего арифметического каждого столбца массива