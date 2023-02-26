//Напишите программу, которая принимает пятизначное число и проверяет,
//является ли оно палиндромом

//14212 ->no
//23432 ->yes
//12321 ->yes


Console.WriteLine("inpit number");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 9999 && N < 100000)
{
    int a = N % 10;
    int b = (N / 10) % 10;
    int c = (N / 1000) % 10;
    int d = (N / 10000) % 10;
    Console.WriteLine(a == d && b == c ? "Число является палиндромом" :
    "Число не является палиндромом");
}
else { Console.WriteLine("Число введено не корректно"); }