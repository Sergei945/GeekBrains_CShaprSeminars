
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// double getNumPow(double num, double pow) 
// {
//   double finishNum = num;
//   for (int i = 0; i < pow - 1; i++)
//     finishNum *= num;  
//   return finishNum;
//   // return Math.Pow(num, pow); 
// }
// Console.Write("Напишите число, которое требуется возвести в степень: ");
// double a = Convert.ToDouble(Console.ReadLine());
// Console.Write("Напишите в какую степень требуется возвести: ");
// double b = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Число {a} в степени {b} равно {getNumPow(a, b)}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int getSumNumber(int num) 
{
  int sum = 0;
  string strNum = num.ToString();
  for (int i = 0; i < strNum.Length; i++)
     sum += strNum[i] - '0';   
  return sum;
}

Console.WriteLine(getSumNumber(452));


// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// m = 5 -> [1, 2, 5, 7, 19]
// m = 3 -> [6, 1, 33]