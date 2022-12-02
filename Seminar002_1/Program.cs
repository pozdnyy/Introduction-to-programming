//Напишите программу, которая выводит случайное 
//трехзначное число и удаляет вторую цифру этого числа.

//456 -> 46
//782 -> 72
//918 -> 98

var random = new Random();

int randomNum = random.Next(100, 1000);//random.Next(10, 100);

System.Console.WriteLine(randomNum);

int num1 = randomNum / 100;

int num2 = (randomNum - num1 * 100)/10;

int num3 = randomNum - num1 * 100 - num2 * 10;

int result = (num1 * 10) + num3;

System.Console.Write(result);