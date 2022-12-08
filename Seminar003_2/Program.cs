/* Напишите программу, которая принимает на вход координаты двух
 точек и находит расстояние между ними в 2D пространстве. */

/*  # - A (3,6);  B (2,1)  -> 5,09
#     - A (7,-5); B (1,-1) -> 7,21 */

Double x1, x2, y1, y2, distance; // double - не целое число , int - целое число
        
Console.Write("Введите координаты x1: ");
x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты y1: ");
y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты x2: ");
x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты y2: ");
y2 = Convert.ToDouble(Console.ReadLine());

distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine($"Расстояние между двумя точками на плоскости равно {distance}");
Console.ReadKey();