// Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
// в которой находится эта точка

Console.WriteLine("Введите координату точки по x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки по y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0) {Console.WriteLine("Точка нахожится в первой координатной четверти");}
else if(x < 0 && y > 0) {Console.WriteLine("Точка нахожится во второй координатной четверти");}
else if(x < 0 && y < 0) {Console.WriteLine("Точка нахожится в третьей координатной четверти");}
else if(x > 0 && y < 0) {Console.WriteLine("Точка нахожится в четвертой координатной четверти");}
else {Console.WriteLine("Невозможно определить координатную четверть");}