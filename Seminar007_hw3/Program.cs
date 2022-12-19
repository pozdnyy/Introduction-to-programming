﻿/* Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Random rnd = new Random();
int[,] collection = new int[rnd.Next(1, 10), rnd.Next(1, 10)];

for (int i = 0; i < collection.GetLength(0); i++)
{
    for (int j = 0; j < collection.GetLength(1); j++)
    {
        collection[i, j] = rnd.Next(1, 10);
        Console.Write(collection[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine(" ");

for (int j = 0; j < collection.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        sum += collection[i, j];
    }
    Console.Write($"{ sum / collection.GetLength(0)} ");
}

Console.ReadLine();