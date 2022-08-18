// Прога принимает на вход число и  выдают сумму цифр в числе...


Console.WriteLine("Введите  число");
int n = int.Parse(Console.ReadLine());
int indexA = n;
int indexB = n;
int sum = 0;
while (indexB > 0)
{
    indexA = indexB % 10;
    indexB = indexB / 10;
    sum = sum + indexA;
}

Console.WriteLine(sum);
