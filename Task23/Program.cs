// 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Insert number: ");

int numb = int.Parse(Console.ReadLine());

for (int i = 1; i <= numb; i++)
{
    Console.WriteLine($"|Куб числа {i, 4} | {Math.Pow(i, 3), 4}|");
}
