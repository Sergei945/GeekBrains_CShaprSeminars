// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

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

  for(int i = 0; i < rows; i++) 
    for (int j = 0; j < columns; j++)
        array[i,j] = new Random().Next(minVal, maxVal + 1);
  return array;
}

void Show2dArray(int[,] array)  
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i,j] + " ");
    Console.WriteLine();
  }
}

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);



// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.

int[,] CreateIndex2dArray(int oneSize, int twoSize) 
{
  int[,] array = new int[oneSize,twoSize];
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
     array[i,j] = i + j;
  return array;
}
Show2dArray(CreateIndex2dArray(5, 10));

// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
void Square2dArrayEven(int[,] array) 
{
    for(int i = 0; i < array.GetLength(0); i += 2) 
      for (int j = 0; j < array.GetLength(1); j += 2)
        array[i,j] *= array[i,j];      
}

// int[,] array = CreateRandom2dArray();
// Show2dArray(array);
// Square2dArrayEven(array);
// Console.WriteLine();
// Show2dArray(array);


// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)

int SumElementMainDiagonal2dArray(int[,] array) 
{
  int sum = 0;
  for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
    sum += array[i,i];
  return sum;
}

int[,] array = CreateRandom2dArray();

Show2dArray(array);
Console.WriteLine(SumElementMainDiagonal2dArray(array));