
// 66 Задать м и н и сумма в их промежутке 

Console.WriteLine($"Введите М");
int m = int.Parse(Console.ReadLine());
Console.WriteLine($"Введите N");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(SummBetween(m,n));

int SummBetween(int a, int b)
{
int summ = 0;
 if (a==b+1) return 0;
 summ = summ +a+  SummBetween(a+1,b);
 return summ;
}
