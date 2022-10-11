// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.

// int SecondNumber(int num) {
//     int result = 0;
//     if(num < 100 || num >= 1000) {
//         Console.WriteLine("Число не трёхзначное.");
//         result = -1;
//     } else {
//         result = (num / 10) % 10;
//     }

//     return result;
// }

// Console.Write("Введите трёхзначное число: ");
// int num = SecondNumber(Convert.ToInt32(Console.ReadLine()));
// if (num != -1){
//     Console.Write($"Вторя цифра - {num}");
// }

// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// int ThirdNumber(int num) {
//     int result = 0;
//     if(num < 100) {
//         Console.WriteLine("Третьей цифры нет.");
//         result = -1;
//     } else {
//         while(num >= 1000) {
//             num /= 10;
//         }
//         result = num % 10;
//     }
//     return result;
// }
// Console.Write("Введите трёхзначное число: ");
// int num = ThirdNumber(Convert.ToInt32(Console.ReadLine()));
// if (num != -1){
//     Console.Write($"Третья цифра - {num}");
// }

// Задача 3: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.


// bool Weekend(int num)
// {
//     if (num < 8 || num > 0)
//     {
//         if (num % 6 == 0 || num % 7 == 0)
//         {
//             Console.WriteLine(num);
//             return true;
//         }
//     }
//     return false;

// }

// // int randomNum =  new Random().Next(1, 7);
// Console.Write("Введите день недели: ");
// bool day = Weekend(Convert.ToInt32(Console.ReadLine()));
// if (day == true)
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }


void WeekendTwoVersion(int num)
{
    
    if (num < 8 || num > 0)
    {
        if (num % 6 == 0 || num % 7 == 0)
        {
            Console.WriteLine("Yes");

        } 
        else 
        {
            Console.WriteLine("No");
        }
    }
}

Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

WeekendTwoVersion(day);