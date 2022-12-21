// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
int number = new Random().Next(100, 1000);
Console.WriteLine("Your Random 3 gigits Number " + number);
int newnumber = number % 100;
int middledigit = newnumber / 10;
Console.WriteLine("Middle digit is " + middledigit);