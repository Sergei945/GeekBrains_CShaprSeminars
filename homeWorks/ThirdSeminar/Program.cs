// Задача 1 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// void Palindrome(int number)
// {
//     if (number < 100000 && number >= 10000)
//     {
//         if ((number % 10) == (number / 10000) && 
//             (12821 % 100) / 10 == (12821 / 1000) % 10)
//         {
//             Console.Write("Да");
//         }
//         else
//         {
//             Console.Write("Нет");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Вы ввели не пятизначное число");
//     }
// }

// Console.Write("Введите пятизначное число в консоль: ");
// int usersNumber = Convert.ToInt32(Console.ReadLine());
// Palindrome(usersNumber);


// Задача 2 Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// double  getDistance3D(double numOneX, double numOneY, double numOneZ, double numTwoX, double numTwoY, double numTwoZ) 
// {
//   double distance = Math.Sqrt((numTwoX - numOneX) * (numTwoX - numOneX) + 
//                             (numTwoY - numOneY) * (numTwoY - numOneY) + 
//                             (numTwoZ - numOneZ) * (numTwoZ - numOneZ));
//   return Math.Round(distance, 2);
// }

// Console.Write("Пропишише координату X первого числа: ");
// double numOneX = Convert.ToDouble(Console.ReadLine());
// Console.Write("Пропишише координату Y первого числа: ");
// double numOneY = Convert.ToDouble(Console.ReadLine());
// Console.Write("Пропишише координату Z второго числа: ");
// double numOneZ = Convert.ToDouble(Console.ReadLine());
// Console.Write("Пропишише координату X второго числа: ");
// double numTwoX = Convert.ToDouble(Console.ReadLine());
// Console.Write("Пропишише координату Y второго числа: ");
// double numTwoY = Convert.ToDouble(Console.ReadLine());
// Console.Write("Пропишише координату Z второго числа: ");
// double numTwoZ = Convert.ToDouble(Console.ReadLine());

// Console.Write( $"Расстояние между ними в 3D пространстве: {getDistance3D(numOneX, numOneY, numOneZ, numTwoX, numTwoY, numTwoZ)}");

// Задача 23 Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void tableCubeNumber(int num) 
// {
//     for (int i = 1; i <= num; i++)
//     {
//         Console.Write(Math.Pow(i, 3) + " ");
//     }
// }


// Console.Write("Введите необходимое число для вывода таблицы кубов чисел: ");
// int usersNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Выша таблица кубов чисел от 1 до {usersNumber} - ");
// tableCubeNumber(usersNumber);