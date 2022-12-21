// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Enter three digit number");
int number = Convert.ToInt32(Console.ReadLine());
if(number >= 100 && number < 1000)
{
    int newnumber = number % 100;
    int middledigit = newnumber / 10;
    Console.WriteLine("Middle digit is " + middledigit);
}
else
{
    Console.WriteLine("Enter three digit number");
}