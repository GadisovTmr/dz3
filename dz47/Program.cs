// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void Fillmatrix(double[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)

{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i,j] = new Random().Next(-100000,100000)/10000.0;
    }
    Console.WriteLine();
}
}

void Printmatrix(double[,] matr)
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
double [,] matrix = new double[3,4];

Fillmatrix(matrix);
Printmatrix(matrix);

