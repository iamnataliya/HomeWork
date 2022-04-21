
// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
/*
Console.Clear();
System.Console.WriteLine();

System.Console.Write("Input number:   ");
string number = Console.ReadLine();
int length = number.Length;
string txtToCheck = number.Replace(" ","");  /// для проверки текста на палиндром

bool Palindrome()
{
    for (int i = 0; i < length / 2; i++)
        while (number[i] == number[length - 1])
        {
            return true;
        }
    return false;
}

if (Palindrome()) System.Console.WriteLine($" input number - {number} - is polindrom");
else System.Console.WriteLine($" Number {number} is NOT polindrom");
System.Console.WriteLine();
*/

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

System.Console.Write("input number:   ");
string writeN = Console.ReadLine();
int N = Convert.ToInt32(writeN);
int[] GetCubeTable(int N)
{
    int[] cubs = new int[N];
    int number = 1;
    for (int i = 0; i < N; i++)
    {
        cubs[i] = number * number * number;
        number++;
    }
    return cubs;
}
void PrintCubs(int[] array)
{
    int number = 1;
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{number} ^ 3 = ");
        System.Console.WriteLine(array[i]);
        number++;
    }
}
int[] CubeTable = GetCubeTable(N);
PrintCubs(CubeTable);