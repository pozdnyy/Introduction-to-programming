/* Задача 56: Задайте прямоугольный двумерный массив. Напишите
 программу, которая будет находить 
строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и
 выдаёт номер строки с наименьшей суммой элементов: 1 строка */

Console.WriteLine("Enter size:");
int vol = Convert.ToInt32(Console.ReadLine());

int[,] collection = new int[vol, vol];

FillRandom(collection);
PrintArray(collection);

int sumMin = Int32.MaxValue;
int index = 0;

for (int i = 0; i < collection.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < collection.GetLength(1); j++)
    {
        sum = sum + collection[i, j];
    }
    if (sum < sumMin)
    {
        sumMin = sum;
        index++;
    }
}

Console.WriteLine("Line number with min sum (" + (index) + "), with the sum of elements equal to =  " + (sumMin));

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write(" ");
        Console.WriteLine("");
    }
}

void FillRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

