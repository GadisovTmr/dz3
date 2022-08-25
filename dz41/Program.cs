//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Сколько чисел вы собираетесь ввести?");
    int m = int.Parse(Console.ReadLine());
    int[] array = new int[m];
    int count  = 0;
    for (int i = 0; i < m; i++)
    {
     Console.WriteLine($"Введите {i + 1}  число");
        array[i] = int.Parse(Console.ReadLine());
    }
for (int i = 0; i < array.Length; i++)
{
    if (array[i]>0) count = count+1;
    else  count = count;
}
Console.WriteLine("Количество чисел больше 0 = " + count );
