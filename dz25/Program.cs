// Цикл  для возведения числа а в степень числа б


Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
int sqr = a;
if (b == 1) Console.WriteLine("равно " + sqr);
else
{
    for (int i = 1; i < b; i++)
    {
        sqr = sqr * a;
    }
    Console.WriteLine("равно" + sqr);
}