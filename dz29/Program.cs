// задать массив из 8 элементов и вывести на экран

int[] massive = new int[8];
int index = 0;
while (index < 8)
{
    int value1 = new Random().Next(0, 100);
    massive[index] = value1;
    index++;
}
Console.Write(massive[0] + " , " + massive[1] + " , " + massive[2] + " , " + massive[3] + " , "
+ massive[4] + " , " + massive[5] + " , " + massive[6] + " , " + massive[7] + ".");

