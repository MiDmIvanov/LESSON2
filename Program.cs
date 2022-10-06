// task1
/*
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
*/

//task2
/*
Console.WriteLine("Введите число от 100 до 2 147 483 647:");
int a = int.Parse(Console.ReadLine());
int i = 100;
if (a/i!=0)
{
    while (i<1000000000)
    {
        if (a/i==0)
        {
            int d = Math.Abs((a%(i/100))/(i/1000));
            Console.WriteLine($"третья цифра {d}");
            break;
        }
        else
        {
            i=i*10;
        }
    }
}
else
{
   Console.WriteLine($"Третьей цифры нет");
}
*/

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