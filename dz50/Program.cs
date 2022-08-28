// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Console.WriteLine("Номер столбца?");
//     int c = int.Parse(Console.ReadLine());
// Console.WriteLine("Номер строки?");
//     int s = int.Parse(Console.ReadLine());
// int[,] matrix = {{1,2,3,},{4,5,6},{7,8,9}};
// if (c>= matrix.GetLength(0) || s>= matrix.GetLength(1)) Console.WriteLine("За пределами");
// else Console.WriteLine($"элемент {matrix[c,s]}");

//  если пользователь не знает про индексацию 

Console.WriteLine("Номер столбца?");
    int c = int.Parse(Console.ReadLine());
   int col = c-1;
Console.WriteLine("Номер строки?");
    int s = int.Parse(Console.ReadLine());
   int str = s-1;
int[,] matrix = {{1,2,3,},{4,5,6},{7,8,9}};
if (col>= matrix.GetLength(0) || str>= matrix.GetLength(1)) Console.WriteLine("За пределами");
else Console.WriteLine($"элемент {matrix[col,str]}");
