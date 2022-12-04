/* Задача 15: Напишите программу, которая принимает на вход 
цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Enter day number : ");
string enterDay = Console.ReadLine();
int day = Convert.ToInt32(enterDay);
string WeekDay = "Monday";

if (day == 1 ) WeekDay = "Monday, not a day off";
if (day == 2 ) WeekDay = "Thuesday, not a day off";
if (day == 3 ) WeekDay = "Wednesday, not a day off";
if (day == 4 ) WeekDay = "Thursday, not a day off";
if (day == 5 ) WeekDay = "Friday, not a day off";
if (day == 6 ) WeekDay = "Saturday, congratulations, it's a day off!";
if (day == 7 ) WeekDay = "Sunday, congratulations, it's a day off!";

if((day > 7) || (day < 1))
{
    Console.WriteLine("Day of the week not found. Please, enter a valid day");
    return;
}
Console.WriteLine(WeekDay);