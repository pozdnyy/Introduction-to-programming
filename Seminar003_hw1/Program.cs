/* Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */

Console.WriteLine ("Ввести 5 значное число: ");
string num = Console.ReadLine();
int leng = num.Length;

if (leng == 5)
{
    if (num[0] == num[4] && num [1] == num[3])
    {
        Console.WriteLine("Да, палиндром");
    }
    else
        {
        Console.WriteLine("Нет, не палиндром");
        }
}