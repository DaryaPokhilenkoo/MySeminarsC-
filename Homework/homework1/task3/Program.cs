/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/


Console.WriteLine("Input N");
int N =Convert.ToInt32(Console.ReadLine());
if (N % 2 == 0)
{
    Console.WriteLine($"{N} is even number");
}

else 
{
    Console.WriteLine($"{N} is not even number");
}