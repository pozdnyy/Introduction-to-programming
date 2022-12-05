/*  # Напишите программу, которая по заданному номеру четверти, показывает диапазон 
возможных координат точек в этой четверти (x и y). */

Console.WriteLine("Please enter number : ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1)
    Console.WriteLine("В первой четверти - x > 0 y > 0");
else if(num == 2)
    Console.WriteLine("Во второй четверти - x < 0 y > 0");
else if(num == 3)
    Console.WriteLine("В третьей четверти - x < 0 y < 0");
else if (num == 4)
    Console.WriteLine("В четвертой четверти - x > 0 y < 0");
else 
    Console.WriteLine("Такой четверти нет :(");