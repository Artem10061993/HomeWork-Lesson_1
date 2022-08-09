// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
Console.WriteLine("Введите число");
double x = Convert.ToDouble(Console.ReadLine());
if(x%2==0) 
{Console.WriteLine("Число "+x+" - ЧЕТНОЕ");}
else
{Console.WriteLine("Число "+x+" - НЕЧЕТНОЕ");}