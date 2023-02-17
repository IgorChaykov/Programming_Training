// See https://aka.ms/new-console-template for more information
System.Console.Write("Введите число от 1 до 4: ");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1 : System.Console.WriteLine(" x>0, y>0");
    break;
    case 2 : System.Console.WriteLine(" x>0, y<0");
    break;
    case 3 : System.Console.WriteLine(" x<0, y<0");
    break;
    case 4 : System.Console.WriteLine(" x<0, y>0");
    break;
    default: System.Console.WriteLine(" ---");
break;
}

