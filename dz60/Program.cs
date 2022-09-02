// № 60 Трехмерный массив из неповторяющихся двухзначных чисел. 
int[,,] array1 = new int [2,2,2];

void Fillmatrix(int[,,] matr)
{
  
for (int i = 0; i < matr.GetLength(0); i++)

{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int k = 0; k < matr.GetLength(2); k++)
        {
            matr[i,j,k] =matr[i,j,k]+ (k+1)+j*2+i*4+10;
         }
              
          }
        }
    }
    Console.WriteLine();

void Printmatrix(int[,,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)

{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int k = 0; k < matr.GetLength(2); k++)
        {
            Console.Write($"{matr[i,j,k]} ({i},{j},{k}) ");
        }
        Console.WriteLine();
    }
    
}
}

Fillmatrix(array1);
Printmatrix(array1);
