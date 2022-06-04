// Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
// Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1

Console.Write("Write text: ");
string[] textMass;
var text = Console.ReadLine();
textMass = text.Split(' ');
Console.Write(value: "Number of words in the text: ");
Console.WriteLine(textMass.Length);
Console.ReadLine();
// Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.
// Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}

string [] SortStrings(string[] words)
{
    for (int i = 0; i < words.Length ; i+=2)
    {
        words[i] = words[i] + words[i+1];
    }
    return words;
}
string[] names = { "qwe", "wer", "ert", "rty", "tyu", "yui"};
SortStrings(names);
for (int i = 0; i < names.Length; i+=2)
{
    Console.Write(names[i] + " ");
}
