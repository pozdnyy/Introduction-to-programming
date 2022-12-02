/* Напишите программу, которая принимает на вход два 
числа и проверяет, является ли одно число квадратом другого.

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
 */

Console.WriteLine("Please enter number1 : ");
string enterNum1 = Console.ReadLine();

Console.WriteLine("Please enter number2 : ");
string enterNum2 = Console.ReadLine();

int num1 = Convert.ToInt32(enterNum1);
int num2 = Convert.ToInt32(enterNum2);

int sqr; 

if(num1 > num2)
{
    sqr = num2 * num2;
    if(sqr == num1)
        Console.WriteLine("Yes");
    else
    {
        Console.WriteLine("No");
    }
}
else
{
    sqr = num1 * num1;
    if(sqr == num2)
        Console.WriteLine("Yes");
    else
    {
        Console.WriteLine("No");
    }
}