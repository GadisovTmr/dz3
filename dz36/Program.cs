//  Сумма элементов на нечетных позициях
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

}

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

int[] array = CreateRandomArray(5,1,100);
int summa = 0;
ShowArray (array);
Console.WriteLine("----------------------------");
for (int i = 0; i < array.Length; i++)
{
    if (i == 0) summa = summa + array[i];
    else if  (i%2 == 0)  summa = summa + array[i];
}
Console.WriteLine(summa);

