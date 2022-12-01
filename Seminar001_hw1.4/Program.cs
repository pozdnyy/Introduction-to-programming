// Задача 8: Напишите программу, которая на вход принимает 
// число (N), а на выходе показывает все чётные
// числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int index = 1;
bool no = true;

Console.WriteLine("Введите число не равное 1:");
int N = Convert.ToInt32(Console.ReadLine());

while (index <= N)
{
    if (index % 2 != 1)
        {
        Console.Write(index + " ");
        no = false;
        }
        index++;
        }

        if (no)
        {
            Console.WriteLine("Введите число не равное 1");
}