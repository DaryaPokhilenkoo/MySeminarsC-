/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/


Console.Write("Input number ");
string num = Console.ReadLine();
void number (string num)
{
    if (num.Length == 5)
{
    number(num);
}
else
{
    Console.WriteLine($"Input correct number");
}

    if (num[0]==num[4] || num[1]==num[3])
    {
      Console.WriteLine($"Your number is palindrome");
    }
    else
{
     Console.WriteLine($"Your number is not palindrome");
}

}
