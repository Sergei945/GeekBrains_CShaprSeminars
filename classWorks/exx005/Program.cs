// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// int GetSum(int num) {
//   int result = 0;
//   for (int i = 1; i <= num; i++) result += i;
//   return result;
// }

// Console.Write("Input a positive integer number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write( $"Sum of numbers from 1 to {a} is {GetSum(a)}");


/* */

// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// int AmountNum(int num) 
// {
//   int corrent = 0;
//   while(num > 0) 
//   {
//     num /= 10;
//     corrent++;
//   }
//   // return num.ToString().Length;
//   return corrent;
// } 

// Console.Write("Напиши число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Количество цифр в числе {num} - {AmountNum(num)}");


// // Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.


// int Factorial(int num) {
//   int result = 1;
//   for (int i = 1; i <= num; i++) result *= i;
//   return result;
// }

// Console.Write("Input a positive integer number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write( $"Factorial of numbers from 1 to {a} is {Factorial(a)}");

// Напишите программу, которая выводит массив из m элементов, заполненный нулями и единицами в случайном порядке.

int[] CreateRandomArray(int size, int minVal, int maxVal) 
{
  int[] array = new int[size];
  
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(minVal, maxVal + 1);
  }

  return array;
}

void ShowArray(int[] array) 
{
foreach (var item in array)
  Console.Write(item + " ");
Console.WriteLine();
}

Console.Write("Input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

ShowArray(CreateRandomArray(size, min, max));

// Сгенерировать метод, который будет у пользователя элементы массива