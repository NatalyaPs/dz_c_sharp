//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

/*Console.WriteLine("введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третье число");
int c = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (max<a) max=a;
if (max<b) max=b;
if (max<c) max=c;

Console.WriteLine(max);*/

//в впервом решении не получается с отрицательными числами. Ответ выдает 0.
// преподаватель Алексей Свищев посоветовал поменять max. Задать это значение 1му числу.
//это позволит избавиться от одной конструкции if и обрабатывать отрицательные числа.
// Пробую:

Console.WriteLine("введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третье число");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (max<b) max=b;
if (max<c) max=c;

Console.WriteLine(max);