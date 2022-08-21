// Количество четных элементов в массиве  

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

int[] array = CreateRandomArray(10,100,999);
int summa = 0;
ShowArray (array);
Console.WriteLine("__________________");
for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2 == 0)
    {
        summa = summa +1;
    }
}
Console.WriteLine(summa);

