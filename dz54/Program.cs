// 54 Двумерный массив упорядочивает по убыванию строки 

int[,] matrix = new int[,] { { 1, 2, 89, 4, 5 }, { 1, 2, 7, 4, 5, } };
void Printmatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)

    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}  ");
        }
        Console.WriteLine();
    }
}
Printmatrix(matrix);

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < (matrix.GetLength(1) - 1); k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int max = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = max;
                }
            }
        }
    }

Console.WriteLine();
Printmatrix(matrix);
