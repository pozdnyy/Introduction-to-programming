/* Задача 13: Напишите программу, которая выводит третью 
цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));

int ReadInt(string num)
{
    Console.Write(num);
    return Convert.ToInt32(Console.ReadLine());
}
int MakeArray(int array, int collection)
{
int result = 0;
    if (collection < 3)
    {
        Console.Write("Третьей цифры нет");
    }
    else
    {
        int index2 = 1;
        for (int index = collection; index > 3; index--)
        {
            index2 = index2 * 10;
        }

        result = (array / index2) % 10;
            }
return result;
}