// Задача 3: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
string number = Console.ReadLine();
int numberInt = int.Parse(number);

if (number.Length > 2)
{
    Console.WriteLine($"Третьей цифрой введенного числа является " + number[2]);
}
else
Console.Write($"{numberInt} -> Третьей цифры нет");