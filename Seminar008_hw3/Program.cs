/* Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int line = ReadInt("Enter the number of lines: ");
int column = ReadInt("Enter number of columns: ");

int[,] collection = new int[line, column];
int[,] array = new int[line, column];
int[,] result = new int[line, column];

FillRandom(collection);
PrintArray(collection);

Console.WriteLine();

FillRandom(array);
PrintArray(array);

Console.WriteLine();

if (collection.GetLength(0) != array.GetLength(1))
{
    Console.WriteLine("Can't be multiplied");
    return;
}
for (int i = 0; i < collection.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        result[i, j] = 0;
        for (int n = 0; n < collection.GetLength(1); n++)
        {
            result[i, j] += collection[i, n] * array[n, j];
        }
    }
}

PrintArray(result);

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

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}