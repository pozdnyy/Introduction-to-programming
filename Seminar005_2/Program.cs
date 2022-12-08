/* Задача 33: Задайте массив. Напишите программу, которая определяет,
 присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
 */

int[] array = { 6, 7, 19, 345, 3 };
Console.WriteLine("Введите искомое число:");
int size = array.Length;
int find = int.Parse(Console.ReadLine());

int index = 0;

while (index < size)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    else
    {
    Console.WriteLine("Нет такого в массиве");
    break;
    }
    index++;
}

