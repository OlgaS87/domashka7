/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.WriteLine("введите число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число n");
int n = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [m, n];
GetArray(numbers);

for (int j = 0; j < numbers.GetLength(1); j++)
{
    double count = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        count = (count + numbers[i, j]);
    }
    count = count / n;
    Console.WriteLine($"Среднее арифметическое {count}");
}
PrintArray(numbers);

void GetArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(0,10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
    Console.WriteLine();
    }
}