// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

System.Console.WriteLine("Напишите число A:");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Напишите число B:");
int b = Convert.ToInt32(Console.ReadLine());
int count = 1;
for (int i = 0; i < b; i++)
{
    count = count * a;
}
Console.WriteLine($"{count} ({a}^{b})");


