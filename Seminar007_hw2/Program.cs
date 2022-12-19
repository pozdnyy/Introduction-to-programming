/* Задача 50. Напишите программу, которая на вход принимает
 позиции элемента в двумерном массиве, и возвращает 
 значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет */

Console.WriteLine("Enter size:");

int q = Convert.ToInt32(Console.ReadLine());
int g = Convert.ToInt32(Console.ReadLine());

int[,] collection = new int[q, g];

for (int i = 0; i < collection.GetLength(0); i++)
{
    for (int j = 0; j < collection.GetLength(1); j++)
        collection[i, j] = Convert.ToInt32(new Random().Next(0, 21));
}

for (int i = 0; i < collection.GetLength(0); i++)
{
    for (int j = 0; j < collection.GetLength(1); j++)
        Console.Write(collection[i, j] + "\t  ");
    Console.WriteLine();
}

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a > q && b > g)
    Console.WriteLine("такого числа нет");
else
{
    object c = collection.GetValue(a, b);
    Console.WriteLine(c);
}