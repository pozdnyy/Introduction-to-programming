﻿/* Задача 10: Напишите программу, которая принимает на
 вход трёхзначное число и на выходе показывает вторую
 цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine("Введите трехзначное число");
    while(true)
    {
        string index = Console.ReadLine();
            Console.WriteLine("{1}",index, index[1]);
            break;
    }