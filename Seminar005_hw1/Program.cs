/* Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите программу,
 которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

Console.WriteLine("Размер массива:  ");

int leng = Convert.ToInt32(Console.ReadLine());
int[] array = new int[leng];
int indx = 0;

FillArray(array);
Console.WriteLine("массив: ");
PrintArray(array);

void FillArray(int[] array) // заполняем массив числами
{
    for (int i = 0; i < array.Length; i++) //конфетка
    {
        array[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] array) // для печати массива
{
    Console.Write(" ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " "); //кавычки чтобы разделять числа в массиве
    }
    Console.Write("");
    Console.WriteLine();
}

for (int z = 0; z < array.Length; z++) // условие счета
    if (array[z] % 2 == 0)
        indx++;

Console.WriteLine($" Четных в массиве - {indx}");