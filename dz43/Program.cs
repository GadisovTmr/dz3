//   Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//   значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
int[,] matrix = new int[2, 2];

Console.WriteLine("Введите b1");
matrix[0, 0] = int.Parse(Console.ReadLine());

Console.WriteLine("Введите k1");
matrix[0, 1] = int.Parse(Console.ReadLine());

Console.WriteLine("Введите b2");
matrix[1, 0] = int.Parse(Console.ReadLine());

Console.WriteLine("Введите k2");
matrix[1, 1] = int.Parse(Console.ReadLine());

int crosspoint = (matrix[1, 0] - matrix[0, 0]) / (matrix[1, 1] - matrix[0, 1]);

Console.WriteLine($"Точка пересечения  {crosspoint} ; {matrix[0, 1] * crosspoint + matrix[0, 0]}"); 
