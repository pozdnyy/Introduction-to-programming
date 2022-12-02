/* Напишите программу, которая будет принимать на вход два числа
и выводить, является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа
выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
 */

Console.WriteLine("Please enter number1 : ");
string enterNum1 = Console.ReadLine();

Console.WriteLine("Please enter number2 : ");
string enterNum2 = Console.ReadLine();

int num1 = Convert.ToInt32(enterNum1);
int num2 = Convert.ToInt32(enterNum2);

int krt = num1 % num2;

if(krt == 0)
{
Console.WriteLine("без остатка");
}
    else
    {
        Console.WriteLine($"не кратно, {krt}");
    }

