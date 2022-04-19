// Домашняя работа №2 
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
// Решение:
void ReduceNumber()
{
    int num = new Random().Next(100, 999);
    Console.Write(num + " -> ");
    int num1 = num / 10 % 10;
  
    Console.Write(num1);
}
ReduceNumber();

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
//Решение:
System.Console.WriteLine();

int Number = new Random().Next(1, 1500);
System.Console.WriteLine();
System.Console.WriteLine($"Дано число: {Number}");

if (Number / 100 > 0) System.Console.WriteLine($"Третьей цифрой числа {Number} является цифра {Number / 100 % 10}");
else System.Console.WriteLine($"У числа {Number} нет третьей цифры");

System.Console.WriteLine();

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
//Решение
System.Console.WriteLine();

int dayNumber = new Random().Next(1, 8);
string[] Days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
string txtResult = "";

if (dayNumber > 5) txtResult = $". Это выходной день!";
else txtResult = $", рабочий день.";

System.Console.WriteLine();
System.Console.WriteLine($"{dayNumber}-й день недели - это {Days[dayNumber - 1]}{txtResult}");
System.Console.WriteLine();
