// Задача 4: Напишите программу, которая принимает
//  на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Please enter number1 : ");
string enterNum1 = Console.ReadLine();

Console.WriteLine("Please enter number2 : ");
string enterNum2 = Console.ReadLine();

Console.WriteLine("Please enter number3 : ");
string enterNum3 = Console.ReadLine();

int num1 = Convert.ToInt32(enterNum1);
int num2 = Convert.ToInt32(enterNum2);
int num3 = Convert.ToInt32(enterNum3);

int max = num1;

if(num2 > max) max = num2;
if(num3 > max) max = num3;

Console.Write("max = ");
Console.WriteLine(max);