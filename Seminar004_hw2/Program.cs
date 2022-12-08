/* Задача 27: Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

Console.WriteLine("Пожалуйста, введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int leng = NumberLen(num);
NumbersSum(num, leng);

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
int NumberLen(int hMnums)
{
    int index = 0;
    while (hMnums > 0)
    {
        hMnums /= 10;
        index++;
    }
    return index;
}

void NumbersSum(int n, int leng)
{
    int sumNum = 0;
    for (int i = 1; i <= leng; i++)
    {
        sumNum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sumNum);
}