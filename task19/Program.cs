/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да  */

Console.WriteLine("Введите пятизначное число: ");
int nam = Convert.ToInt32(Console.ReadLine());
string str = nam.ToString();

if (str[0] == str[4] && str[1] == str[3])
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}