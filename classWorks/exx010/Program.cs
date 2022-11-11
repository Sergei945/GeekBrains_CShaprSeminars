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

// Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от 1 до N.
// Посмотреть фильм НАЧАЛО 
void ShowNums(int num) 
{
  Console.Write(num + " ");
  if(num > 1) ShowNums(num - 1);
  Console.Write(num + " ");
}

// ShowNums(5);

// Напишите программу, которая будет принимать на вход число 
// и возвращать сумму его цифр.

int SumOfDigits(int num) 
{
  if(num != 0) return SumOfDigits(num / 10) + num % 10;
  else return 0;
}

Console.WriteLine(SumOfDigits(12345));




// Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N.

void NaturalNumbers(int m, int n) 
{
  if(m > n) 
  {
    NaturalNumbers(m - 1, n);
    Console.Write(m + " ");
  }
  if(m < n) 
  {
    NaturalNumbers(m, n - 1);
    Console.Write(n + " ");
  }
  if(m == n) 
    Console.Write(n + " ");
}
// NaturalNumbers(10, 1);
// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B.

double sqr(int a, int b) 
{
  if(b > 0) 
  {
    return a * sqr(a, b - 1);
  }
  else
  {
    return 1;
  }
  if(b < 0) 
  {
    return 1 / (a * sqr(a, b + 1));
  }
}

Console.WriteLine(sqr(2, -3));