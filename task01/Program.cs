//Задача 1: Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.

System.Console.WriteLine("Введите трехзначное число: ");
string number = Console.ReadLine();
int numberInt = int.Parse(number);

if (number.Length != 3)
{
    System.Console.WriteLine("Ведено не трехзначное число");
}
else
System.Console.WriteLine($"Второй цифрой трехзначного числа {numberInt} является " + numberInt % 100 / 10);