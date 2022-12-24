// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Enter number, which idicates the day of the week.");
int number = Convert.ToInt32(Console.ReadLine());
if(number <= 5 && number > 0)
{
    Console.WriteLine("This is workday, pal.");
}
else if(number <= 7 && number > 5)
{
    Console.WriteLine("Welcome to the weekend.");
}
else
{
    Console.WriteLine("Try again.");
}