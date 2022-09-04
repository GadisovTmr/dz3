// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа 

Console.WriteLine($"Введите М");
int m = int.Parse(Console.ReadLine());
Console.WriteLine($"Введите N");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(AkkermanFunct(m,n));
 
 int AkkermanFunct(int n, int m)
{
if (n == 0) return m + 1;
                if (n > 0 && m == 0) return AkkermanFunct(n - 1, 1);
                if (n > 0 && m > 0) return AkkermanFunct(n - 1, AkkermanFunct(n, m - 1));
                return AkkermanFunct(n,m);
}
 