/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки 
двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int[,] col = new int[3, 4];

FillRandom(col);
PrintArray(col);
SortingArray(col);

Console.WriteLine();
PrintArray(col);

void SortingArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            for (int n = 0; n < collection.GetLength(1) - 1; n++)
            {
                if (collection[i, n] < collection[i, n + 1])
                {
                    int temp = collection[i, n + 1];
                    collection[i, n + 1] = collection[i, n];
                    collection[i, n] = temp;
                }
            }
        }
    }
}

void FillRandom(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            Console.Write($"{collection[i, j]} ");
        }
        Console.WriteLine();
    }
}

