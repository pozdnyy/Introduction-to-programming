/* Задача 21

Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между ними 
в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

Double x1, x2, y1, y2, z1, z2, distance; // double - не целое число , int - целое число
        
Console.Write("Введите координаты x1: ");
x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты y1: ");
y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты z1: ");
z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты x2: ");
x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты y2: ");
y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты z2: ");
z2 = Convert.ToDouble(Console.ReadLine());

distance = Math.Sqrt((x2-x1) * (x2-x1) + (y2 - y1) * (y2 - y1) + (z1 - z2) * (z1 - z2));
Console.WriteLine($"Расстояние между двумя точками на плоскости равно {distance}");