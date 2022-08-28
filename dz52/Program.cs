// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void Printmatrix(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)

{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i,j]}  ");
    }
    Console.WriteLine();
}
}
void Fillmatrix(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)

{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i,j] = new Random().Next(1,10);
    }
    Console.WriteLine();
}
}
int[,] matrix = new int[3,4];
Fillmatrix(matrix);
Console.WriteLine();
Printmatrix(matrix);
double sqr = 0;
for (int i = 0; i < matrix.GetLength(1); i++)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        sqr = sqr + matrix[j,i];
    }
    Console.WriteLine();
Console.WriteLine ($" = {sqr/3}");
sqr=sqr*0;
}
