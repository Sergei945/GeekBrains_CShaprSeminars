
void ShowArray(int[] array) 
{
  foreach (var item in array)
    Console.Write(item + " ");
  Console.WriteLine();
}


int[] CreateRandomArray(int size, int minVal, int maxVal) 
{
  int[] array = new int[size];
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(minVal, maxVal + 1);
  return array;
}

int[] CreateArray(int size) 
{
  int[] array = new int[size];
  Console.WriteLine("Creating array: ");
  for (int i = 0; i < size; i++)
  {
    Console.Write($"Input a {i + 1} element of array: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
  }
  Console.WriteLine("Complete!");
  return array;
}


// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных элементов массива.


int SumOfNegatives(int[] array) 
{
  int sum = 0;
  for (int i = 0; i < array.Length; i++)
    if(array[i] < 0) 
      sum += array[i];
  return sum;
}

// CreateRandomArray(int size, int minVal, int maxVal); 


// Console.Write("Input a number of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);

// ShowArray(myArray);

// int result = SumOfNegatives(myArray);
// Console.WriteLine("Sum of negative elements is " + result);

// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

// int[] NegativeArray(int[] arr) 
// {
//   for (int i = 0; i < arr.Length; i++)
//   {
//     arr[i] = -arr[i];
//   }
//   return arr;
// }
// int[] arr = CreateRandomArray(12, -10, 10);

// ShowArray(NegativeArray(arr));

// Задайте массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// int NumOfTwoArray(int[] arr) 
// {
//   int count = 0;
//   for (int i = 0; i < arr.Length; i++)
//   {
//     if(arr[i] >= 10 && arr[i] <= 99) 
//     {
//       count++;
//     }
//   }
//   return count;
// }

// int[] arr = CreateRandomArray(12, 0, 200);
// ShowArray(arr);

// Console.WriteLine(NumOfTwoArray(arr));
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

bool FindNumber(int[] arr, int num) 
{
  for (int i = 0; i < arr.Length; i++)
  {
    if(arr[i] == num) 
      return true;
  }
  return false;
}

int[] arr = CreateArray(5);

Console.Write("Введите требуемое значение для поиска в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());

if(FindNumber(arr, num)) 
{
  Console.WriteLine($"число {num} есть в массиве");
} else 
{
  Console.WriteLine($"число {num} нет в массиве");
}
