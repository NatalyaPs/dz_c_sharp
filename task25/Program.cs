/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
Использование Math.Pow и аналогов = незачёт  */

Console.WriteLine("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В: ");
int B = Convert.ToInt32(Console.ReadLine());
int C = 1;
for(int i=0; i<B; i++)
{
    C*=A;         
}
Console.WriteLine($"Число А в степени В равно: {C}");
