// Задача №1. Напишите программу, которая на вход принимает два 
//числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет

Console.WriteLine("Enter number1 : ");
string enterNum1 = Console.ReadLine();

Console.WriteLine("Enter number2 : ");
string enterNum2 = Console.ReadLine();

int num1 = Convert.ToInt32(enterNum1);
int num2 = Convert.ToInt32(enterNum2);

int sqr = num2 * num2;

if(num1 == sqr)
{
    Console.WriteLine("Yes");
}
else 
{
    Console.WriteLine("No");
}
