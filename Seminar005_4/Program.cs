/* Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */
int count = 5;
int[] array = new int[count];
int endNum = array.Length / 2;

if (array.Length % 2 == 1) endNum++;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 11);
}
Console.WriteLine(string.Join(", ", array));

int[] array2 = new int[endNum];

int j = array.Length - 1;

for (int i = 0; i < array.Length / 2; i++)
{
    array2[i] = array[i] * array[j - i];
}
if (array.Length % 2 == 1)
{
    array2[endNum - 1] = array[endNum - 1];
}
Console.WriteLine(string.Join(", ", array2));