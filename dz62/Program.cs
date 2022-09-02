// № 62 Массив 4 на 4 спирально

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
 
 int[,] matrix = new int[4,4];
 int m = 4;
int first = 1;

for (int i = 0; i < m; i++)
{
    matrix[0,i] = first;
    first++;
}
for (int i = 1; i < m; i++)
{
    matrix[i,m-1] = first;
    first++; 
}

for (int i = m-2; i >= 0; i--)
{
   matrix[m-1,i] = first;
   first++;
}

for (int i = m-2; i > 0; i--)
{
  matrix[i,0] = first;
   first++;
}
for (int i = m-3; i < m-1; i++)
{
    matrix[1,i] = first;
    first++;
}
for (int i = 2; i < m-1; i++)
{
    matrix[i,m-2] = first;
    first++; 
}
matrix[2,1] = 16; //))) 
  Printmatrix(matrix);

