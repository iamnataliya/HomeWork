/*
Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
//Решение
Console.WriteLine("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
    Console.WriteLine("First number is biger then second number");
else
    Console.WriteLine("First number is less than second number");

//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
//Решение
Console.WriteLine("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num1 > num2 && num1 > num3) max = num1;
if (num2 > num3 && num2 > num1) max = num2;
if (num3 > num1 && num3 > num2) max = num3;
Console.Write("Max = ");
Console.WriteLine(max);
/*
Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
//Решение
Console.WriteLine("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 % 2 == 0)
Console.WriteLine("Number is even");
else
Console.WriteLine("Number is NOT even");
*/
//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
//Решение
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 1;
while(current <= num)
{
    Console.Write(current + " ");
    current++;
}