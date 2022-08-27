// Дополнительная задача на рекурсию
// Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N. (использовать рекурсию)
// 4 -> 24
// 5 -> 120

int Namber (int n)
{
    if (n == 1) return 1;
    else return n * Namber(n-1);
}

Console.WriteLine("Введите число N: ");
int nam = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Произведение чисел от 1 до N = {Namber(nam)}");

