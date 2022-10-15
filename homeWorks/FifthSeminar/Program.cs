// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2





// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0






// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76






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

