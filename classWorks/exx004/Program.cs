// Math.Pow(a, b) - Возвращает указанное число, возведенное в указанную степень.
// Math.Sqrt(a) - Возвращает квадратный корень из указанного числа.

// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


// int  FindQuart(double x, double y) {
//   int num = 0;

//   if(x > 0 && y > 0) {
//     num = 1;
//   }
//   if(x < 0 && y > 0) {
//     num = 2;
//   }
//   if(x < 0 && y < 0) {
//     num = 3;
//   }
//   if(x > 0 && y < 0) {
//     num = 4;
//   }
//   return num;
// }

// Console.Write("Input x-coordinate: ");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input y-coordinate: ");
// double y = Convert.ToDouble(Console.ReadLine());

// int quartNum = FindQuart(x, y);

// Console.WriteLine($"The point A ({x},{y}) is in {quartNum}");

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

double  getDistance(double numOneX, double numOneY, double numTwoX, double numTwoY) 
{
  double distance = Math.Sqrt((numTwoX - numOneX) * (numTwoX - numOneX) + (numTwoY - numOneY) * (numTwoY - numOneY));
  return Math.Round(distance, 2);
}
Console.Write("Пропичише координату X первого числа: ");
double numOneX = Convert.ToDouble(Console.ReadLine());
Console.Write("Пропичише координату Y первого числа: ");
double numOneY = Convert.ToDouble(Console.ReadLine());
Console.Write("Пропичише координату X второго числа: ");
double numTwoX = Convert.ToDouble(Console.ReadLine());
Console.Write("Пропичише координату Y второго числа: ");
double numTwoY = Convert.ToDouble(Console.ReadLine());

Console.Write( $"Расстояние между ними в 2D пространстве: {getDistance(numOneX, numOneY,  numTwoX, numTwoY)}");


// Напишите программу, которая принимает на вход число (N) и выдаёт ряд квадратов чисел от 1 до N.

void showSqrt(int num) 
{
  for (int i = 1; i < num; i++)

  {
    Console.WriteLine(i * i);
  }

}

Console.Write("Напишите число для подсчёта ряда квадратов числа: ");
int numOneX = Convert.ToInt32(Console.ReadLine());

showSqrt(numOneX);
