/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
*/

void SortRows2dArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    int temp;
    for (int j = 0; j < array.GetLength(1) - 1; j++)
      for (int x = 0; x < array.GetLength(1) - j - 1; x++)
        if (array[i, x + 1] > array[i, x])
        {
          temp = array[i, x + 1];
          array[i, x + 1] = array[i, x];
          array[i, x] = temp;
        }
  }
}

// int[,] myArray = CreateRandom2dArray(5, 5, 1, 9);

// Show2dArray(myArray);
// SortRows2dArray(myArray);
// Console.WriteLine();
// Show2dArray(myArray);
/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

void MaxSumRow2dArray(int[,] array)
{
  if (array.GetLength(0) != array.GetLength(1))
  {
    int[] sumRowArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
      int num = 0;
      for (int j = 0; j < array.GetLength(1); j++)
        num += array[i, j];
      sumRowArray[i] = num;
    }
    int sumMinRow = sumRowArray[0];
    int indexSumMinRow = 0;

    for (int i = 1; i < sumRowArray.Length; i++)
      if (sumMinRow > sumRowArray[i])
      {
        sumMinRow = sumRowArray[i];
        indexSumMinRow = i;
      }
    Console.WriteLine($"Строка с наименьшей суммой элементов - {indexSumMinRow + 1} сумма строки равна - {sumMinRow}");
  }
  else
    Console.WriteLine("Массив квадратный");
}

// int[,] myArray = CreateRandom2dArray(5, 6, 1, 5);
// Show2dArray(myArray);
// Console.WriteLine();
// MaxSumRow2dArray(myArray);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] MatrixMultiply(int[,] oneMatrix, int[,] twoMatrix)
{
  int matrix1Rows = oneMatrix.GetLength(0);
  int matrix1Cols = oneMatrix.GetLength(1);
  int matrix2Rows = twoMatrix.GetLength(0);
  int matrix2Cols = twoMatrix.GetLength(1);
  int[,] product = new int[matrix1Rows, matrix2Cols];
  if (oneMatrix.GetLength(1) == twoMatrix.GetLength(0))
    for (int matrix1_row = 0; matrix1_row < matrix1Rows; matrix1_row++)
      for (int matrix2_col = 0; matrix2_col < matrix2Cols; matrix2_col++)
        for (int matrix1_col = 0; matrix1_col < matrix1Cols; matrix1_col++)
          product[matrix1_row, matrix2_col] +=
            oneMatrix[matrix1_row, matrix1_col] *
            twoMatrix[matrix1_col, matrix2_col];
  return product;
}

int[,] arrayOne = CreateRandom2dArray(2, 2, 1, 5);
Show2dArray(arrayOne);
Console.WriteLine();
int[,] arrayTwo = CreateRandom2dArray(2, 2, 1, 5);
Show2dArray(arrayTwo);
Console.WriteLine();
int[,] matrixMult = MatrixMultiply(arrayOne, arrayTwo);
Show2dArray(matrixMult);
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateRandom3dArray(int rows, int columns, int planes)
{
  int[,,] array3d = new int[rows, columns, planes];
  int[] notRepeatArray = new int[rows * columns * planes];
  if (rows * columns * planes < 100)
    for (int x = 0; x < array3d.GetLength(0); x++)
      for (int y = 0; y < array3d.GetLength(1); y++)
        for (int z = 0; z < array3d.GetLength(2); z++)
        {
          int randomNum = 0;
          for (int r = 0; r < notRepeatArray.Length; r++)
          {
            randomNum = new Random().Next(10, 100);
            if (randomNum == notRepeatArray[r])
              continue;
            notRepeatArray[x + y + z] = randomNum;
          }
          array3d[x, y, z] = randomNum;
        }
  else
    Console.WriteLine("Данный массив не может быть создан в рамках текущего задания поэтому заполнен нулями");
  return array3d;
}

void Show3dArray(int[,,] array3d)
{
  for (int x = 0; x < array3d.GetLength(0); x++)
  {
    for (int y = 0; y < array3d.GetLength(1); y++)
      for (int z = 0; z < array3d.GetLength(2); z++)
        Console.Write($"| {array3d[x, y, z]} ({x},{y},{z}) |");
    Console.WriteLine("X");
  }
}

// int[,,] array3d = CreateRandom3dArray(3, 4, 3);
// Show3dArray(array3d);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateSpiralArray(int size)
{
  int[,] array = new int[size, size];
  int x = 0, y = 0;
  int currentCount = 1;
  while (size > 0)
  {
    for (int i = y; i <= y + size - 1; i++)
      array[x, i] = currentCount++;
    for (int j = x + 1; j <= x + size - 1; j++)
      array[j, y + size - 1] = currentCount++;
    for (int i = y + size - 2; i >= y; i--)
      array[x + size - 1, i] = currentCount++;
    for (int i = x + size - 2; i >= x + 1; i--)
      array[i, y] = currentCount++;
    x++;
    y++;
    size = size - 2;
  }
  return (array);
}

int[,] array = CreateSpiralArray(6);
ShowSpiral(array);


int[,] CreateRandom2dArray(int rows, int columns, int minVal, int maxVal)
{
  int[,] array = new int[rows, columns];
  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
      array[i, j] = new Random().Next(minVal, maxVal + 1);
  return array;
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

void ShowSpiral(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      if (array[i, j] < 10)
        Console.Write("0" + array[i, j] + " ");
      else
        Console.Write(array[i, j] + " ");
    Console.WriteLine();
  }
}