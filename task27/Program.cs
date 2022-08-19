/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12    */

Console.WriteLine("Введите число: ");
int namber = Convert.ToInt32(Console.ReadLine());
namber = Math.Abs(namber);
int sum = 0;

while (namber > 0)    
{   
    sum = sum + namber % 10;
    namber = namber / 10;
}
Console.WriteLine($"Сумма цифр в числе равна {sum}");