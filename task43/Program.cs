// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("");
Console.WriteLine("Для нахождения точки пересечения двух прямых, "
                +"заданных уравнениями y=k1*x+b1, y=k2*x+b2 "
                +"введите значения переменных:");

Console.WriteLine("Введите точку b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите точку b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

if (k1 != k2)    //деление на 0  // k1, k2 - угловые коэф-ты; b1, b2 - пересечение прямых с осью y
                                //в точке пересечения обе координаты y будут совпадать
{
    double x = (b2-b1) / (k1-k2);
    double y = k1 * x + b1; //или подставить х? -> y=(k1* (b2-b1) / (k1-k2)) + b1
    Console.WriteLine($"Точка пересечения двух прямых имеет координаты: {Math.Round(x, 2)}; {Math.Round(y, 2)}");
}

if (k1 == k2 && b1 != b2)
{
Console.WriteLine("Прямые параллельны");
}

if (k1 == k2 && b1 == b2) 
{
    Console.WriteLine("Прямые совпадают");
}
