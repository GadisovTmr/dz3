// 64 Значения м и Н и все натур числа между ними
// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.WriteLine($"Введите М");
int m = int.Parse(Console.ReadLine());
Console.WriteLine($"Введите N");
int n = int.Parse(Console.ReadLine());
NumbersBetween(m,n);
void NumbersBetween(int a, int b)
{
    Console.Write($" {a} ");
if (a == b)  return;
NumbersBetween(a+1,b); 
}
