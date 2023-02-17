// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter N: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int n = 1; N >= n; n++)
{
    Console.Write(Math.Pow(n, 3));
    Console.Write(" ");
}
if (N < 1)
{
    Console.Write($"{N} not included in the specified segment");
}