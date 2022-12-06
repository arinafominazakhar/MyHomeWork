// Домашняя работа.
// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if( a > b )
{
    Console.WriteLine("max = a");
}
else
{
    Console.WriteLine("max = b");
}
*/

// Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a third number: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if(a < b)
{
    max = b;
}
if(b < c)
{
    max = c;
}
if(c < a)
{
    max = a;
}
Console.WriteLine($"max number = {max}");
*/

// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input a number: ");
int current = Convert.ToInt32(Console.ReadLine());

if(current % 2 == 0)
{
    Console.WriteLine("Yes!");
}
else
{
    Console.WriteLine("No!");
}
*/

// Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Input a number: ");
int N = Convert.ToInt32(Console.ReadLine());
int current = 2;

while(current <= N)
{
    Console.Write(current + " ");
    current += 2;
}
*/