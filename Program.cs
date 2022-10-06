//task2
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
