/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

Console.WriteLine("Размер массива:  ");
int leng = Convert.ToInt32(Console.ReadLine());

double[] array = new double[leng];
FillArray(array);

PrintArray(array);
double min = Int32.MaxValue;
double max = Int32.MinValue;

void FillArray(double[] array) //заполняем массив (дабл для больших данных (вещественное число) )
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}

void PrintArray(double[] array) // метод для печати массива
{
    Console.Write(" ");
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    Console.Write(" ");
    Console.WriteLine();
}

for (int n = 0; n < array.Length; n++) // условие
{
    if (array[n] > max)
        {
            max = array[n];
        }
    if (array[n] < min)
        {
            min = array[n];
        }
}
Console.WriteLine($"Максимум = {max}, минимум = {min}");
Console.WriteLine($"Разница  = {max - min}");