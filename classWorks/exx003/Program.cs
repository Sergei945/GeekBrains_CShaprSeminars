// Напишите программу, которая принимает двузначное число и показывает наибольшую цифру числа.

// int FindBiggerDigit(int num) {
//   int result;

//   int ed = num % 10;
//   int dec = num / 10;

//   if (ed > dec) 
//     result = ed;
//   else
//     result = dec;
//   return result;
// }


// Console.Write("Input a two-digit number: ");
// int number =- Convert.ToInt32(Console.ReadLine());

// int biggerDigit = FindBiggerDigit(number);
// Console.WriteLine($"Bigger digit of {number} is {biggerDigit}");


// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int numberEx = new Random().Next(99, 1000);
Console.WriteLine(numberEx);
int RandomThirdNumber(int num) {
  int oneNumber = num / 100;
  int thirdNumber = num % 10;
  return oneNumber * 10 + thirdNumber;
}
Console.WriteLine(RandomThirdNumber(numberEx));

// Напишите программу, которая принимает на вход число n и проверяет, +
// кратно ли оно одновременно a и b(целочисленные делители, также задаются пользователем).

// Console.WriteLine("Введите число для проверки");
// int num = Console.ReadLine();
// Console.WriteLine("Введите делитель один");
// int delOne = Console.ReadLine();
// Console.WriteLine("Введите делитель два");
// int delTwo = Console.ReadLine();


// int krat(int x, int y, int z)
// {
//     if(x % y == 0 && x % z == 0)
//     {
//         return 1;
//     }
//     else
//     {
//         return 0;
//     }
// }
// Console.WriteLine("Введите N");
// int n =  Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите 1 делитель");
// int number1 =  Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите 2 делитель");
// int number2 = Convert.ToInt32(Console.ReadLine());
// int del = krat(n, number1, number2);
// Console.WriteLine(del);

bool Del(int num, int num1, int num2) {
  if(num % num1 == 0 && num % num2 == 0) {
    return true;
  }
  return false;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первый делитель: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второй делитель: ");
int b = Convert.ToInt32(Console.ReadLine());
bool suc = Del(number, a, b);
Console.WriteLine($"Ответ: {suc}");



