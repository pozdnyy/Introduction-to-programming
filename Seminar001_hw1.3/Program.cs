// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Enter num : ");
string enterNum = Console.ReadLine();

int num = Convert.ToInt32(enterNum);

if(num%2 != 0)
    {
        Console.WriteLine("NO");
    }
    else
        {
            Console.WriteLine("YES");
        }