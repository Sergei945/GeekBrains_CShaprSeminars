//    int[] ReverseSeq(int n)
//     {
//         int[] arr = new int[n];

//         for (int i = 0; i < arr.Length; i++)
//         {
//         arr[i] = arr.Length - i;

//         }
//         return arr;

//     }
//     void ShowArray(int[] array) 
//   {
//   foreach (var item in array)
//     Console.Write(item + " ");
//   Console.WriteLine();
//   }
// ShowArray(ReverseSeq(5));

// static int StringToNumber(String str) 
// {
//         //TODO: Convert str into a number
//       return Convert.ToInt32(str);
// }
// Console.WriteLine(StringToNumber("555"));


// static int StringToNumberVer2(String str)
// {
//     return (int.Parse(str));
// }

// static string FindNeedle(object[] haystack)
//   {

//   //Code goes here!

//   }

// var haystack_1 = new object[]{'3', "123124234", null, "needle", "world", "hay", 2, '3', true, false};

// string Rps(string p1, string p2)
//   {
//     string win = "";

//     // scissorts, rock, paper
//     if(p1 == "scissors" && p2 == "paper" || 
//         p1 == "paper" && p2 == "rock" || 
//         p1 == "rock" && p2 == "scissors") 
//     {
//         win = "Player 1 won!";
//     } 
//     else if(p2 == "scissors" && p1 == "paper" || 
//             p2 == "paper" && p1 == "rock" || 
//             p2 == "rock" && p1 == "scissors") 
//     {
//         win = "Player 2 won!";
//     }
//     else 
//     {
//         win = "Draw!";
//     }
//     {

//     }
//     return win;
//   }

// Console.WriteLine(Rps("rock", "rock"));

// bool IsIsogram(string str) 
//   {

//     for(int i = 0; i < str.Length; i++) {
//       int count = 1;
//       for(int j = i + 1; j < str.Length; j++) {
//         if(Char.ToLower(str[i]) == Char.ToLower(str[j])) {
//           count++;
//             Console.WriteLine(str[j]);
//             }
//       }
//       if(count > 1) {
//         return false;

//       }
//     }
//   return true;
//   }

// Console.WriteLine(IsIsogram("moOse"));


// int sumTwoSmallestNumbers(int[] numbers)
// 	{
//     Array.Sort(numbers);
//     return numbers[0] + numbers[1];
// }

// int[] numbers = {10, 343445353, 3453445, 2147483647};
// Console.WriteLine(sumTwoSmallestNumbers(numbers));


// char[] charOne = (str).ToArray();

// static string SortString(string s1, string s2)
// {
//     string str = s1 + s2;
//     char[] charArr = new char[(str).Length];
//     for (int i = 0; i < charArr.Length; i++)   
//     {
//         charArr[i] = str[i];
//     }

//     Array.Sort(charArr);


//     for (int i = 0; i < charArr.Length; i++)
//     {
//         if(charArr[i] == '-')
//             continue; 
//         for (int j = i + 1; j < charArr.Length; j++)
//         {
//             if(charArr[j] == '-') {
//                 continue;
//             } else {
//                 if(charArr[i].Equals(charArr[j])) {
//                 charArr[j] = '-';
//             }    
//         }
//         }
//     }
//     return new string(charArr).Replace("-", "");
// }




// string Longest (string s1, string s2) 
//   {
//         return new string ((s1 +s2).Distinct().OrderBy(x=>x).ToArray ());
//   }



// Console.WriteLine(Longest("xyaabbbccccdefww" , "xxxxyyyyabklmopq"));
// string str = SortString("xyaabbbccccdefww", "xxxxyyyyabklmopq");


// int Litres(double time)
//   {
//     double count = 0;

//     while(time > 0) {
//         time -= 1;
//         count += 0.5;
//         // Console.Write(time + " ");

//     }
//     return Convert.ToInt32(Math.Floor(count));
//   }

// Console.WriteLine(Litres(1.4));

// int Litres(double time)
//   {  
//     return Convert.ToInt32(Math.Floor(time / 2));
//   }

// Console.WriteLine(Litres(11.8));


// int SquareDigits(int n)
//   {
//     string str = n.ToString();
//      Console.WriteLine(str.Length);
//     string finishStr = "";
//     for (int i = 0; i < str.Length; i++)
//     {

//         int a = Convert.ToInt32(str[i]) ;
//         a *= a;
//         finishStr += a.ToString();
//         Console.WriteLine(a);
//     }
//     return Convert.ToInt32(finishStr);
//   }

// Console.WriteLine(SquareDigits(9119));

// int n = 99224234;
// string str = n.ToString();
// Console.Write(str);

// Завершите метод, который принимает логическое значение и возвращает "Yes"строку для true, или "No"строку для false.

//  string boolToWord(bool word)
//   {
//     return word ? "Yes" : "No";
//   }

// Ваша задача — написать функцию, которая возвращает сумму следующих рядов до n-го члена (параметра).
// Series: 1 + 1/4 + 1/7 + 1/10 + 1/13 + 1/16 +...
// 1 --> 1 --> "1.00"
// 2 --> 1 + 1/4 --> "1.25"
// 5 --> 1 + 1/4 + 1/7 + 1/10 + 1/13 --> "1.57"

// string seriesSum(int n)
// {
//     string str = "";
//     double dbl = 0;
//     if (n == 0)
//     {
//         return "0.00";
//     }
//     else if (n == 1)
//     {
//         return "1.00";
//     }
//     else
//     {
//         double count = 1;
//         for (int i = 0; i < n; i++)
//         {
//             dbl += 1 / count;
//             count += 3;
//         }
//         dbl = Math.Round(dbl, 2);  
//     }
//     str += dbl.ToString();
//     if(str.Length == 3) {
//         str += "0";
//     }

//     return str;
// }

// string seriesSum (int n) {
//     double ret = 0;
//     for (var i = 1; i <= n; i++) 
//     {
//       ret += 1f/(3 * i - 2);
//     }
//     return ret.ToString("0.00");
//   }
// Console.WriteLine(seriesSum(58));

//  string NumberToString(int num)
//   {
//    return num.ToString();
//   }

// Создайте функцию, которая отвечает на вопрос «Вы играете на банджо?».
// Если ваше имя начинается с буквы «R» или строчной «r», вы играете на банджо!

// Функция принимает имя в качестве единственного аргумента и возвращает одну из следующих строк:
// name + " plays banjo" 
// name + " does not play banjo"

// string AreYouPlayingBanjo(string name)
// {
//     return name.ToLower()[0] == 'r' ? $"{name} plays banjo" : $"{name} does not play banjo";
// }

// Console.WriteLine(AreYouPlayingBanjo("pich"));

// int NbYear(int p0, double percent, int aug, int p)
// {
//     int count = 0;
//     int finish = p0;
//     while (finish <= p)
//     {
//         finish += Convert.ToInt32(finish * (percent * 0.01)) + aug;
//         Console.Write(Convert.ToInt32(finish * (percent * 0.01)) + " ");
//         count++;
//     }
//     return count;
// }
// Console.WriteLine(NbYear(1000, 2, 50, 1200));

// Console.WriteLine(2 * 0.01);


// Complete the solution so that it returns true if the first argument(string) 
// passed in ends with the 2nd argument (also a string).

// solution('abc', 'bc') // returns true
// solution('abc', 'd') // returns false


// bool Solution(string str, string ending)
// {
//   if(ending == "") 
//     return true;
//   else if(str[str.Length - 1] == ending[ending.Length - 1])
//     return str.Contains(ending);
//   return false;
// }

// Console.WriteLine(Solution("samurai",""));

// bool Solution(string str, string ending)
// {
//   return str.EndsWith(ending);
// }


// string MakeUpperCase(string str)
// {
//     return str.ToUpper();
// }


// string CountSheep(int n)
// {
//   string str = "";
//     for (int i = 1; i <= n; i++)
//         str += $"{i} sheep...";
//     return str;
// }
// Console.WriteLine(CountSheep(5));

// public static string CountSheep(int n)
// {
//   return string.Concat(Enumerable.Range(1, n).Select(i => $"{i} sheep..."));
// }

// string EvenOrOdd(int number)
// {
//     return number % 2 == 0 ? "Even" : "Odd";
// }

// int[] CountBy(int x, int n)
//   {
//     int[] z = new int[n];
//     for (int i = 0; i < n; i++)
//         z[i] = (i + 1) * x;
//     return z;
//   }

// int[] CountBy(int x, int n)=>Enumerable.Range(1,n).Select(i=>i*x).ToArray();

// ShowArray(CountBy(1, 50));
  
void ShowArray(int[] array) 
{
  foreach (var item in array)
    Console.Write(item + " ");
  Console.WriteLine();
}


// Цель была вывести длину самого короткого слова
  // int FindShort(string s)
  // {
  //   string[] array = s.Split(' ');
  //   int j = array[0].Length;
  //   for (int i = 1; i < array.Length; i++)
  //     if(array[i].Length < j)
  //       j = array[i].Length;
  //   return j;
  // }
  // public static int FindShort(string s)
  // {
  //   return s.Split(' ').Min(x => x.Length);
  // }

// Console.Write(FindShort("bitcoin take over the world maybe who knows perhaps"));


// bool Hero(int bullets, int dragons)
//   {
//     return dragons * 2 <= bullets;
//   }
// Console.Write(Hero(1500, 750));



// // способ нахождения минимального элемента в массиве и его вывод.
// int FindSmallestInt(int[] args) 
//   {
//     return args.Min();
//   }

// // Если чётный умножаем на 8, если нет то на 9
//   int Multiply(int x) 
//   {
//     return x % 2 == 0 ? x * 8 : x * 9;
//   }


 int GetAge(string inputString)
  {
    return inputString[0] - '0';
  }

  // public static int GetAge(string inputString)
  // {
  //   return (int)char.GetNumericValue(inputString[0]);
  // }
Console.WriteLine(GetAge("5555"));


