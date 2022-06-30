// 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Insert coordinates of the Point1");
Console.Write("X1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Z1: ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Insert coordinates of the Point2");
Console.Write("X2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Z2: ");
int z2 = int.Parse(Console.ReadLine());

int resultX = Math.Abs(x1 - x2);
int resultY = Math.Abs(y1 - y2);
int resultZ = Math.Abs(z1 - z2);

// Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(resultX, 2)+Math.Pow(resultY, 2)+Math.Pow(resultZ, 2)), 2));

double powX = Math.Pow(resultX, 2);
double powY = Math.Pow(resultY, 2);
double powZ = Math.Pow(resultZ, 2);

double result = Math.Sqrt(powX + powY + powZ);
Console.WriteLine(Math.Round(result, 2));
