 // Напишите программу, которая принимает на вход число (N)
 //и выдаёт таблицу кубов чисел от 1 до N.
 // 3 -> 1, 8, 27.
 // 5 -> 1, 8, 27, 64 125

// Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// int index = 0;
// while (index <=N) 
// {
//     double a = Math.Pow(index,3);
//     Console.WriteLine(a);
//     index++;
// }

int ReadNumber(string message) {Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int N = ReadNumber("Inpit num");
for(int i = 1; i <=N; i++) {
    Console.WriteLine(Math.Pow(i,3));
}