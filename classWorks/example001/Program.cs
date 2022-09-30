// int number = 0;
// double number1 = 1.5;
// string name = "525";
// bool check = true;

// Console.Write(name);

// Console.Write("Input a number: ");

// int number = Convert.ToInt32(Console.ReadLine()) ;

// Console.WriteLine("Your number is "  + number);

// Example 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

// Console.Write("Input a first number: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second number: ");
// int n2 = Convert.ToInt32(Console.ReadLine());

// int q2 = n2 * n2;

// if (n1 == q2)
// {
//   Console.WriteLine("Yes");
// }
// else
// {
//   Console.WriteLine("No");
// }

// Example 2. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

// Console.Write("Input a number: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int current = -(n);

// while (current <= n)
// {
//   Console.Write(current + " ");
//   current++;
// }

// Example 3. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

// 3162 % 10 -> 2 
// 3162 % 100 -> 62
// 3162 % 1000 -> 162 

// 3162 / 10 -> 316
// 3162 / 100 -> 31
// 3162 / 1000 -> 3

// 82736 / 100 = 827 % 100 = 27
// 5243 / 10 % 10

// Console.Write(5243 / 10 % 10 );

Console.Write("Input a three-digit number ");
int n = Convert.ToInt32(Console.ReadLine());

if(n >= 100 && n < 1000) {
  Console.WriteLine("Last digit of " + n + " is " + n % 10);
  Console.WriteLine($"Last digit of {n} is {n % 10}");
} else {
  Console.WriteLine("Uncorrect input!");
}
 
