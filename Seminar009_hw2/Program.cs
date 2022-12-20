/* Задача 66: Задайте значения M и N. Напишите программу,
 которая найдёт сумму натуральных элементов 
 в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Enter seed M:");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Enter seed N:");
int N = int.Parse(Console.ReadLine());

void SpaceSum(int M, int N, int sum)
{
    if (M > N)
    {
        Console.WriteLine($"Sum of natural elements: {sum}");
        return;
    }
    sum = sum + (M++);
    SpaceSum(M, N, sum);
}

SpaceSum(M, N, 0);