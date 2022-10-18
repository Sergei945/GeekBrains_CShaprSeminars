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
int[] CreateRandomArray(int size, int minVal, int maxVal) 
{
  int[] array = new int[size];
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(minVal, maxVal + 1);
  return array;
}
void ShowArray(int[] array) 
{
  foreach (var item in array)
    Console.Write(item + " ");
  Console.WriteLine();
}





// int[] ChangeArray(int[] array) 
// {
//   int[] newArray = new int[array.Length];
//   for (int i = 1; i < array.Length; i++)
//   {
//     newArray[i] = array[i] + 10;
//   }
//   return newArray;
// }
// int[] myArray = CreateRandomArray(10, 0, 10);
// int[] newArray = ChangeArray(myArray);

// ShowArray(myArray);
// ShowArray(newArray);
// ShowArray(myArray);


// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// void ChangeArray(int[] array) 
// {
//   for (int i = 0, j = array.Length - 1; i < j; i++, j--) 
//   {
//     int temp = array[i];
//     array[i] = array[j];
//     array[j] = temp;
//   }
// }

// int[] myArray = CreateRandomArray(10, 0, 10);

// ShowArray(myArray);
// ChangeArray(myArray);
// ShowArray(myArray);


// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// Каждая сторона триугольника должна быть строго меньше суммы двух других сторон

bool Triangle(int a, int b, int c) 
{
  if(a < b + c && b < a + c && c < a + b) {
    return true;
  } 
  return false;
}

Console.Write(Triangle(5, 10, 10));


// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] NewArray(int[] array) 
{
  int[] newArray = new int[array.Length];
  for (int i = 0; i < array.Length; i++)
    newArray[i] = array[i];
   return newArray;
}
int[] myArray = CreateRandomArray(10, 0, 10);
int[] newArray = NewArray(myArray);

ShowArray(myArray);
ShowArray(newArray);
ShowArray(myArray);

//  Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.

// Ряд фибоначи это числовая последовательность это каждый новый элемент является суммой первых двух элементов

int[] fibanaci(int size, int numOne, int numTwo) 
{
  int[] array = new int[size];
  array[0] = numOne;
  array[1] = numTwo;
  for (int i = 2; i < size; i++)
  {
    array[i] = array[i - 1] + array[i - 2];  
  }
  return array;
}

Console.Write("Напишите размер выводимого числа фибоначи: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите первое число фибоначи: ");
int numOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите второе число фибоначи: ");
int numTwo = Convert.ToInt32(Console.ReadLine());

Console.Write("Последовательность числа фибоначи равна: ");
ShowArray(fibanaci(size, numOne, numTwo));
