
// #56 Прямоугольный двмерный массив, поиск строки с меньшей суммой

int[,] matrix = new int[,] { { 1, 2, 12, 5 }, { 1, 7, 4, 5 }, {5,12,7,2}, {12,2,6,3} };

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
Printmatrix(matrix);
int StrSum (int[,] matr, int numberofStr)
{
    int stringSum =0;
for (int i = 0; i < matr.GetLength(1); i++)
{
    stringSum = stringSum + matr[numberofStr-1,i]; 
}
return stringSum;
}

int sumFirstStr = StrSum(matrix,1);
int sumSecondStr = StrSum(matrix,2);
int sumThirdStr = StrSum(matrix,3);
int sumFourhStr = StrSum(matrix,4);

if (sumFirstStr<sumSecondStr && sumFirstStr<sumThirdStr && sumFirstStr<sumFourhStr) Console.WriteLine("1 строка"); 
else if (sumSecondStr<sumThirdStr && sumSecondStr< sumFourhStr) Console.WriteLine("2 строка");
else if (sumThirdStr<sumFourhStr) Console.WriteLine("3 строка");
else Console.WriteLine("4 строка");
