/* Задача 62. Напишите программу, которая заполнит 
спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

Console.WriteLine("Enter size (n * n):");
int lenght = Convert.ToInt32(Console.ReadLine());
int[,] collection = new int[lenght, lenght];
FillArray(collection, lenght);
ArrayPrint(collection);

void ArrayPrint(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array, int m)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < m * m; e++)
    {
        int n = 0;
        do { array[i, j++] = value++; } while (++n < m - 1);
        for (n = 0; n < m - 1; n++) array[i++, j] = value++;
        for (n = 0; n < m - 1; n++) array[i, j--] = value++;
        for (n = 0; n < m - 1; n++) array[i--, j] = value++;
        ++i;
        ++j;

        m = m < 2 ? 0 : m - 2;
    }
}

