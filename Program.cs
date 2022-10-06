//task3
Console.WriteLine($"Введите число от 1 до 7:");
int a = int.Parse(Console.ReadLine());
if (a>0&a<8)
{
    if (a>5)
    {Console.WriteLine($"Это выходной");}
    else
    {Console.WriteLine($"Это будний день");}
}
else
{Console.WriteLine($"Введено некорректное число");}
