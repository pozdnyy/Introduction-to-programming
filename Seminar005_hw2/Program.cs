/* Задача 36: Задайте одномерный массив, заполненный
 случайными числами. Найдите сумму элементов,
  стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

Console.WriteLine("Размер массива  ");

int leng = Convert.ToInt32(Console.ReadLine());
int[] array = new int[leng];
int sum = 0;

FillArray(array);
Console.WriteLine(" ");
PrintArray(array);

void FillArray(int[] array) // заполнить случайными числами
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] array) // печатаем массив
{
    Console.Write(" ");
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    Console.Write(" ");
    Console.WriteLine();
}
for (int n = 0; n < array.Length; n+=2)
    sum = sum + array[n];

    Console.WriteLine($"Сумма элементов нечетных позиций = {sum}");