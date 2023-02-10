// See https://aka.ms/new-console-template for more information
Console.WriteLine("I need three numbers: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Bigger number is  ");
if (a > b)
{
    if (a > c)
    {
        Console.WriteLine(a);
    }
    else 
    {
        Console.WriteLine(c);
    }
}
else 
{
  if (b > c)
    {
        Console.WriteLine(b);
    }
    else 
    {   
        Console.WriteLine(c);
    }  
}
