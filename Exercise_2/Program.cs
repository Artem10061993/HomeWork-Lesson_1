// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт максимальное.
Console.WriteLine("Введите первое число");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число");
double y = Convert.ToDouble(Console.ReadLine());
if(x>y) 
{Console.WriteLine("Первое число больше второго, максимальное число = "+x);}
else
{Console.WriteLine("Второе число больше первого, максимальное число = "+y);}