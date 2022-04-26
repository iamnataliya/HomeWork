
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int size = 20;
int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
void PrintResult(int[] array)
{
    int even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
        if (array[i] % 2 == 0) even++;
    }
    System.Console.WriteLine($"Количество четных чисел {even}");
}

PrintResult(FillArray(size));

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
void SumOdd(int[] array)
{
    int sum = 0;
    for (int j = 0; j < array.Length; j += 2)
    {
        sum += array[j];
    }
    Console.WriteLine("Sum of odd indices " + sum);
}
Console.Write("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max number: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
SumOdd(myArray);

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[,] array = new double[1, 10];

Random random = new Random();
for (int i = 0; i < 1; i++)
{
    for (int j = 0; j < 10; j++)
    {
        array[i, j] = random.NextDouble() * 100;
        Console.Write(array[i, j]);
    }
    Console.WriteLine();
}
void FindMaxMin(double[,] array) 
{
    double max = array[0,0];
    double min = array[0,0];
    double sum = 0;
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            if(array[i,j] > max)
                max = array[i,j];
            else if(array[i,j] < min)
                min = array[i,j];
            sum = max - min;
        }
    }
    Console.WriteLine("Max = ",max);
    Console.WriteLine("Min = ",min);
    Console.WriteLine("Difference = ",sum);
}
FindMaxMin(array);