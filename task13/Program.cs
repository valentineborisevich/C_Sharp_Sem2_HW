// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
Console.WriteLine("Enter any number. I will return third digit");
string number = Console.ReadLine();
char[] contents = number.ToCharArray();
int n = contents.Length;
if(n > 2 && Char.IsDigit (contents[2]))
{
    Console.WriteLine(contents[2]);
}
else
{
    Console.WriteLine("Try again. There's no third digit");
}

