// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a number: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
if (N < count)
{
    Console.WriteLine("you need to enter a number greater than 1");
}
else
{
if (count == N)
    Console.WriteLine("there are no even numbers in this segment");
else
{
while (count != N)
{
    if (count % 2 == 0)
    {
        Console.WriteLine(count);
    }
    count++;
}
if (count % 2 == 0)
{
  Console.WriteLine(count);  
}
}
}