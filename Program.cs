// task1
Console.WriteLine("Введите трехзначное число:");
int a = int.Parse(Console.ReadLine());
if (a/100>0&a/100<10)
{
    int b = a/10;
    int c = a/100;
    int d = b-c*10;
    Console.WriteLine($"Вторая цифра {d}");
}
else
{
   Console.WriteLine($"Число должно быть трехзначным");
}
