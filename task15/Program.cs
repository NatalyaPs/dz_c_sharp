/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите число от 1 до 7: ");
int i = Convert.ToInt32(Console.ReadLine());
int count = 0;

if (i<6)
{
    Console.WriteLine("нет");
    count ++;
}
else Console.WriteLine("да");