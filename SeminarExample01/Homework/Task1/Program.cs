// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.Write("This number is bigger: ");
    Console.WriteLine(a);
    Console.Write("This number is smaller: ");
    Console.WriteLine(b);
}
else
{
    Console.Write("This number is bigger: ");
    Console.WriteLine(b);
    Console.Write("This number is smaller: ");
    Console.WriteLine(a);
}