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


// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.


// void ChangeArray(int[,] array) 
// {
//   for(int i = 0; i < array.GetLength(0) - 1; i++)
//     for(int j = i + 1; j < array.GetLength(1); j++)
//     {
//       int temp = array[i,j];
//       array[i,j] = array[j,i];
//       array[j,i] = temp;
//     }
// }          

// int[,] myArray = CreateRandom2dArray(4,4,1,9);

// Show2dArray(myArray);
// ChangeArray(myArray);
// Console.WriteLine();
// Show2dArray(myArray);


// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и 
// последнюю строку массива.

void ChangeColumn(int[,] array, int rowOne, int rowTwo) 
{
    if(rowOne < array.GetLength(0) && rowTwo < array.GetLength(0))
        for (int i = 0; i < array.GetLength(1); i++)
        {
            int temp = array[rowOne,i];
            array[rowOne, i] = array[rowTwo, i];
            array[rowTwo, i] = temp;
        } 
        else 
        {
            Console.WriteLine("Невозможно заменить");
        }
}

// int[,] myArray = CreateRandom2dArray(4,4,1,9);

// Show2dArray(myArray);
// ChangeColumn(myArray, 2, 1);
// Console.WriteLine();
// Show2dArray(myArray);
// Из двумерного массива целых чисел удалить строку и столбец, на пересечении 
// которых расположен наименьший элемент.

int[,] CutArray(int[,] array) 
{
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if(array[i , j] < array[minI , minJ]) 
            {
                minI = i;
                minJ = j;
            }

    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0, x = 0; i < array.GetLength(0); i++)
        if(i != minI) 
        {
            for (int j = 0, y = 0; j < array.GetLength(1); j++)
                if(j != minJ) 
                {
                    newArray[x,y] = array[i,j];
                    y++;
                }
            x++;
        }  
    return newArray;    
}
int[,] myArray = CreateRandom2dArray(4,4,1,9);

Show2dArray(myArray);
int[,] newArray = CutArray(myArray);
Console.WriteLine();
Show2dArray(newArray);