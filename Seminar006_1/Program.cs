/* Задача 39:
Напишите программу, которая перевернёт
одномерный массив (последний элемент будет на первом
месте, а первый на последнем и т.д.)
[1 2 3 4 5]
--> [5 4 3 2
[6 7 3 6]
--> [6 3 7
 */

/* int[] array = { 2, 4, 6, 8 };
Array.Reverse(array);

Console.WriteLine(String.Join(',', array)); */

int size = 0;

while (size <= 0)
{
    Console.Write("Введите размер массива: ");
    size = int.Parse(Console.ReadLine());
}

int[] array = new int[size];
var rnd = new Random();

for (int i = 0; i < array.Length; i++)
    array[i] = rnd.Next(1, 100);

Console.WriteLine(String.Join(" ", array));

int j = 0;
int temp = 0;

while (j <= array.Length - 1 - j)
{
    temp = array[j];
    array[j] = array[size - 1 - j];
    array[size - 1 - j] = temp;
    j++;
}

Console.WriteLine(String.Join(" ", array));