// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input the first number");
string example1 = Console.ReadLine();
int a = Convert.ToInt32(example1);
Console.WriteLine("Input the second number");
string example2 = Console.ReadLine();
int b = Convert.ToInt32(example2);
if (a%b == 0)
     Console.WriteLine($"{a} делится на {b}");
     else
{
           int left = a % b;
           Console.WriteLine($"{a} не делится на {b}, остаток {left}");
}
