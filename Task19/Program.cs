// 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//Прямое решение
Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

int first = number / 10000;
int last = number % 10;
int second = (number % 10000) / 1000;
int prelast = (number % 100) / 10;
if (first == last && second == prelast)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");

//Унифицирвоанное решение
// Console.Write("Введите проверяемое: ");
// string check = Console.ReadLine();
// int symb = 0;
// for (int i = 0; i < (check.Length / 2); i++)
// {
//     // Console.WriteLine(check[i]);
//     if (check[i] == check[check.Length - 1 - i])
//     {
//         symb = 1;
//         // Console.WriteLine(symb);
//     }
//     else
//     {
//         symb = 0;
//         // Console.WriteLine(symb);
//         break;
//     }
// }
// if (symb == 1)
//     Console.WriteLine("да");
// else
//     Console.WriteLine("нет");
