
// #58 Произведение двух матриц 
int[,] matrixA = new int[,] { { 2,4 }, { 3,2  } };
int[,] matrixB = new int[,] { { 3,4 }, { 3,3} };

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

Printmatrix(matrixA);
Console.WriteLine();
Printmatrix(matrixB);

int[,] matrixSum = new int [2,2];
matrixSum[0,0] = matrixA[0,0]* matrixB[0,0] + matrixA[0,1]*matrixB[1,0];
matrixSum[0,1] = matrixA[0,0]* matrixB[0,1] + matrixA[0,1]*matrixB[1,1];

matrixSum[1,0] = matrixA[1,0]* matrixB[0,0] + matrixA[1,1]*matrixB[1,0];
matrixSum[1,1] = matrixA[1,0]* matrixB[0,1] + matrixA[1,1]*matrixB[1,1];
Console.WriteLine();;
Printmatrix(matrixSum);
