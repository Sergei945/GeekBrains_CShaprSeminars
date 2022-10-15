// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int EvenNumberArray(int[] arr) 
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
        if(arr[i] % 2 == 0) 
            count++;
    return count;
}

// Console.Write("Введите количество трёхзначных чисел в массиве: ");

// int num = Convert.ToInt32(Console.ReadLine());
// int[] arr  = CreateRandomArray(num, 100, 999);
// ShowArray(arr);

// Console.WriteLine($"Созданный Вами массив имеет - {EvenNumberArray(arr)} чётных чисел");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int UnevenSumArrPosition(int[] arr) 
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
        if((i + 1) % 2 != 0) 
            count += arr[i];
    return count;
}

// Console.Write("Введите количество чисел в массиве: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение элемента в массиве: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение элемента в массиве: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] arr  = CreateRandomArray(size, min, max);
// ShowArray(arr);

// Console.WriteLine($"Массив размером {size} с значениями внутри от {min} до {max} сумма элементов, на нечётных позициях которого - {UnevenSumArrPosition(arr)}");

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int DifferenceMinMaxArray(int[] arr) 
{
    int min = arr[0];
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(min > arr[i])
            min = arr[i];
        if(max < arr[i])
            max = arr[i];
    }
    return max - min;
}

// Console.Write("Введите количество чисел в создаваемом массиве: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] arr  = CreateArray(size);
// ShowArray(arr);

// Console.WriteLine($"Разница между максимальным и минимальным массива равна - {DifferenceMinMaxArray(arr)}");

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
  Console.WriteLine("Создаём массив: ");
  for (int i = 0; i < size; i++)
  {
    Console.Write($"Введите значение {i + 1} элемента массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
  }
  Console.WriteLine("Готово!");
  return array;
}

