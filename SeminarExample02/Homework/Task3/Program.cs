// See https://aka.ms/new-console-template for more information
Console.WriteLine("enter the number of the day of the week");
int dayN = Convert.ToInt32(Console.ReadLine());
 switch (dayN)
{
    case 1 : System.Console.WriteLine("no");
    break;
    case 2 : System.Console.WriteLine("no");
    break;
    case 3 : System.Console.WriteLine("no");
    break;
    case 4 : System.Console.WriteLine("no");
    break;
    case 5 : System.Console.WriteLine("no");
    break;
    case 6 : System.Console.WriteLine("yes");
    break;
    case 7 : System.Console.WriteLine("yes");
    break;
    default: System.Console.WriteLine("there is no such day in the week");
    break;
} 
