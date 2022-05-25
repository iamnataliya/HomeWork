// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int n = 3;
int m = 5;
int temp = m;
if (m > n) 
{
  m = n; 
  n = temp;
}
PrintSumm(m, n, temp=0);
void PrintSumm(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов= {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ);
}

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumNum(int number)
{
    int sum = 0;
    if (number == 0)
        return 0;
    else sum = number % 10 + SumNum(number / 10);
    return sum;
}
Console.Write("Input number: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write(SumNum(numA));
