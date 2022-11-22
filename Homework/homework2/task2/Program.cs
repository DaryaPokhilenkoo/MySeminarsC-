/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет*/
Console.WriteLine("Input number ");
int num =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input size");
string size =Convert.ToString(num);

    if (size.Length > 2)
    {
          Console.WriteLine("three number -> " + size[2]);
       
    }

else 
{
    Console.WriteLine($"{num} does not have 3 numbers");
}

