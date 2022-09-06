// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

Console.WriteLine("Введите число m: ");
uint m = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
uint n = Convert.ToUInt32(Console.ReadLine());

uint Akkerman (uint m, uint n)
{
    if (m == 0)
    {
        return n+1; 
    } 
    else if (m > 0 && n == 0)
    {
        return Akkerman(m- 1, 1);
    }
    else
    //else if (m > 0 && n > 0)
    {
        return Akkerman(m-1, Akkerman(m, n-1));
    }
}
//Akkerman(m,n);
Console.WriteLine(Akkerman(m, n));