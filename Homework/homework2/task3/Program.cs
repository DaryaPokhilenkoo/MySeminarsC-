/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

bool main (int k)
{
    if (k == 6 || k == 7)
    {
        return true ;
    }
    else
    {
         return false;
    }
}
 Console.WriteLine($"{main(7)}");