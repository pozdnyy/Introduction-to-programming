/* Задача 60. ...Сформируйте трёхмерный массив из
 неповторяющихся двузначных чисел. Напишите
  программу, которая будет построчно выводить 
  массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2

66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int[,,] collection = new int[2, 2, 2];
FillArray(collection);
IndexPrint(collection);

void FillArray(int[,,] array)
{
    int count = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(2); n++)
            {
                array[n, i, j] += count;
                count += 3;
            }
        }
    }
}
 
void IndexPrint(int[,,] array)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int n = 0; n < collection.GetLength(2); n++)
            {
                Console.Write($"{collection[i, j, n]}({i},{j},{n}) ");
            }
        }
    }
}

