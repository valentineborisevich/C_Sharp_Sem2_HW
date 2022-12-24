// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
Console.WriteLine("Enter three digit number");
int number = Convert.ToInt32(Console.ReadLine());
int newnumber = number % 100;
int thirddigit = newnumber % 10;
Console.WriteLine("Third digit is " + thirddigit);

