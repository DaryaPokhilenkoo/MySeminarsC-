﻿/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("Input number 1");
int num1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2");
int num2 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 3");
int num3 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input size");
int max = num1;

if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;
{ 
    Console.WriteLine($"{max} is max num");
}