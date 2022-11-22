/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

void Twonum (int num)
{
    int des = num / 10;
    int des2 =des % 10;
    Console.WriteLine($"Twonumber {des2}");
}
Console.Write("Input ThreeDigitNumber");
Twonum(Convert.ToInt32(Console.ReadLine()));
