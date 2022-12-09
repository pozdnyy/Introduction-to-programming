﻿//метод, который принимает число, и возвращает факториал числа


/* int Factorial (int n)
{
    // 1! = 1
    // 0! = 1
    if(n == 1) return 1;
    else return n * Factorial(n - 1);
}
Console.WriteLine(Factorial(3)); //1*2*3 = 6 */
///////////////////////////////////////////////////////////
// решение 40!
/* double Factorial (int n) // тип данных double - потому что может хранить большие цифры в себе
{
    // 1! = 1
    // 0! = 1
    if(n == 1) return 1;
    else return n * Factorial(n - 1);
}
for (int i = 1; i< 40; i++)
{
Console.WriteLine($"{i}! = {Factorial(i)}");
}

 */
///////////////////////////////////////////////////////////
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

int Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for(int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}
