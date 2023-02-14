int a = 4;
int b = 2;
if (a == b*b)
{
    Console.WriteLine($"{a} in the square of {b}");
}
else if (b == a*a)
{
    Console.WriteLine($"{b} in the square of {a}");
}
else 
Console.WriteLine("false");
