Random createNumber = new Random();
int number = createNumber.Next(10, 100);
int a = number/10;
int b = number%10;
if (a>b)
{
    Console.WriteLine($"Первая цифра больше второй {a}>{b}");
}
else if (a<b)
{
    Console.WriteLine($"Первая цифра меньше второй {a}<{b}");
}
else
{
    Console.WriteLine($"Первая цифра равна второй {a}=={b}");
}
