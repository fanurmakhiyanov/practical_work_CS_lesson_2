// Задача 2: Напишите программу, которая выводит случайное трёхзначное
// число и удаляет вторую цифру этого числа.

int number = new Random().Next(100, 999);
System.Console.WriteLine(number);

int number1 = number / 100;
int number2 = number % 100 / 10;
int number3 = number % 10;

System.Console.Write($"{number1}_{number3}");