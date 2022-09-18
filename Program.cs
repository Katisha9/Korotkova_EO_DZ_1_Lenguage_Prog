/*
// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число:");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
   Console.WriteLine($"Первое число ({number1}) больше второго ({number2})");
}
else if (number1 < number2)
{
    Console.WriteLine($"Второе число ({number2}) больше первого ({number1})");
}
else 
{
 Console.WriteLine($"Первое число ({number1}) равно второму({number2})");
}

//2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());

int max = Math.Max(number3, Math.Max(number1, number2));
Console.WriteLine(max);


// 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0)
{
  Console.WriteLine("Число является четным");
}
else
{
  Console.WriteLine("Число является нечетным");
}
*/
// 4.Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());

int a = 1;

while (a <= n)
{
    if (a % 2 == 0)
    {
        Console.WriteLine(a);
    }
    a++;
}