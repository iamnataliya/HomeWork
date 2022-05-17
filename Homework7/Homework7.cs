//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,]CreateRandomArray(
    int m,
    int n)
{
    double[,] array = new double [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().NextDouble()*100 - 10;
            Console.Write("{0,6:F2}", array[i,j]);
        }
        Console.WriteLine();
    }       
    return array;
}
Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());
CreateRandomArray(m,n);

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
