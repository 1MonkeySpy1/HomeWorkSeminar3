// Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53



double Dot(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double x1 = Dot("Введите координату по оси Х первой точки");
double y1 = Dot("Введите координату по оси y первой точки");
double z1 = Dot("Введите координату по оси z первой точки");
double x2 = Dot("Введите координату по оси Х второй точки");
double y2 = Dot("Введите координату по оси y второй точки");
double z2 = Dot("Введите координату по оси z второй точки");

double c = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между точками = {c:f2}");