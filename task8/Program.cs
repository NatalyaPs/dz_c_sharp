﻿//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("введите число");
int N = Convert.ToInt32(Console.ReadLine());
int n = 1;
while (n <= N)
{
    if (n % 2 == 0)
    {
        Console.WriteLine(n);
        n++;
    }
    else
    {
        n++;
    }
    
}
            