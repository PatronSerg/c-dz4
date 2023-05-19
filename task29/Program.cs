
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Random lesha = new Random();

int[] iarek = new int[8];
Console.Write("[");
for (int i = 0; i < 8; i++)
{
    iarek[i] = Convert.ToInt32(lesha.Next(0, 99));

    Console.Write($"{iarek[i]}, ");
}
Console.Write("]");