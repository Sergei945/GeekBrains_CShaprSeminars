// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateDoubleRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = Math.Round(new Random().Next(minVal, maxVal + 1) + new Random().NextDouble(), 1);
    return array;
}

// Show2dArray(CreateDoubleRandom2dArray());




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет

string StockIndex2dArray(int[,] array, int row, int column)
{
    return array.GetLength(0) <= row && array.GetLength(1) <= column ? "No this element in this 2d array" : $"Yes this element [{row}, {column}] 2d array stock in and have value - {array[row, column]}";
}

// int[,] array = CreateRandom2dArray();

// Console.WriteLine(StockIndex2dArray(array, 5, 5));

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:


double[] AverageNumber(int[,] array)
{
    double[] doubleArray = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int count = 0;
        for (int j = 0; j < array.GetLength(0); j++, count++)
          doubleArray[i] += array[j, i];
        doubleArray[i] /= count;
    }
    return doubleArray;
}

int[,] array = CreateRandom2dArray();

Show2dArray(array);

ShowArray(AverageNumber(array));



void ShowArray(double[] array) 
{
  foreach (var item in array)
    Console.Write(item + " ");
  Console.WriteLine();
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minVal, maxVal + 1);
    return array;
}