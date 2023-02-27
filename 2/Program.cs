// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.Write("Введите координату x числа А: ");
int[] coordsA = new int[3];
coordsA[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату y числа А: ");
coordsA[1] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату z числа А: ");
coordsA[2] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату x числа B: ");
int[] coordsB = new int[3];
coordsB[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату y числа B: ");
coordsB[1] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату z числа B: ");
coordsB[2] = Convert.ToInt32(Console.ReadLine());
double distX = Math.Pow(coordsB[0]-coordsA[0], 2);
double distY = Math.Pow(coordsB[1]-coordsA[1], 2);
double distZ = Math.Pow(coordsB[2]-coordsA[2], 2);
double result = Math.Sqrt(distX+distY+distZ);
System.Console.Write(Math.Round(result, 2));