// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter three-digit number ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100 || num > 999)
{
    Console.WriteLine($"{num} is not a three-digit number");
}
else 
{
    num = num / 10;
    num = num % 10;
    Console.WriteLine(num);
}
