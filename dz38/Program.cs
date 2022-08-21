// Разница между максимальным и минималным элементом

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

int[] array = CreateRandomArray(10,-100,100);
int min = array[0];
int max = array[0];
ShowArray (array);
Console.WriteLine("----------------------------");
for (int i = 0; i < array.Length; i++)
{
    if (array[i]>max) max = array[i];
    if (array[i]<min) min = array[i];

}
Console.WriteLine($"Минимальное значение = {min}, Максимальное значение = {max}, разница  = {max-min}");
