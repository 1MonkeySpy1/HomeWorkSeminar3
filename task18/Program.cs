// double x = 4;
// double y = 2;
// double a = Math.Pow(x,y); //x ^ y
// Console.WriteLine(a);

//  Напишите программу, которая по заданному номеру четверти, 
//  показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер координатнойтной четверти");
int NumCoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine
(
    NumCoord == 1 ? "Координаты x > 0 & y > 0":
    NumCoord == 2 ? "Координаты x < 0 & y > 0":
    NumCoord == 3 ? "Координаты x < 0 & y < 0":
    NumCoord == 4 ? "Координаты x > 0 & y < 0":
    "Неправильно введен номер координатной четверти"
);

