//Задача 4: Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.

System.Console.Write("Введите цифру, соответствующую дню недели: ");
string number = Console.ReadLine();
int numberInt = int.Parse(number);

if (numberInt > 7) 
{
    System.Console.WriteLine("Дня недели с таким номером не существует");
}
else if (numberInt < 6)
{
    System.Console.WriteLine($"День под номером {numberInt} является рабочим, если Вы работаете по графику 5/2");
}
else if (numberInt == 6 || numberInt == 7)
{
    System.Console.WriteLine($"День под номером {numberInt} является выходным, если Вы работаете по графику 5/2");
}