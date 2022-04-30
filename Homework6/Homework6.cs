// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

System.Console.WriteLine();
int volume = 5;                // колчество ввода чисел
int count = 0;
int n = 1;

while (volume > 0)
{
    System.Console.Write($"Input number{n} :");
    var num = Console.ReadLine();
    int number = Convert.ToInt32(num);
    if (number > 0) count++;
    volume--;
    n++;
}
System.Console.WriteLine($"Numbers greater then zero: {count}");

//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10
// Двоичное в десятичное пример: 100112 = 1*2^4 + 0*2^3 + 0*2^2 + 1*2^1 + 1*2^0 = 16+0+0+2+1 = 19.

Console.Clear();
System.Console.WriteLine();
System.Console.Write("Введите число:   ");
string writeNum = Console.ReadLine();
int number = Convert.ToInt32(writeNum);

int[] ConvertToBinary(int num)
{
    int num2 = num;
    int size = 0;
    while (num > 0)
    {
        num = num / 2;
        size++;
    }

    int[] binary = new int[size];
    for (int i = size - 1; i >= 0; i--)
    {
        binary[i] = num2 % 2;
        num2 = num2 / 2;
    }
    return binary;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
    }
}

PrintArray(ConvertToBinary(number));

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
