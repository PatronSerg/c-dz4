// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum(int n)
{
    int count = 0;

    while ( n > 0 )
    {
        count = count + n%10;
        n=n/10;
    }
    return count ;
}

System.Console.WriteLine("Введите число :");
int n = Convert.ToInt32(Console.ReadLine());
// int res = Sum(n);
Console.WriteLine(Sum(n));

