/* Задача 68: Напишите программу вычисления функции
 Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.WriteLine("Enter seed m:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Enter seed n:");
int n = int.Parse(Console.ReadLine());

int Function(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Function(m - 1, 1);
    if (m > 0 && n > 0) return Function(m - 1, Function(m, n - 1));
    return Function(m, n);
}

Console.WriteLine($"Ackermann function for numbers ({m},{n}) = {Function(m, n)}");