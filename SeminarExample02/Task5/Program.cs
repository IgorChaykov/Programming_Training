// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input the first number");
string example1 = Console.ReadLine();
int a = Convert.ToInt32(example1);
//Console.WriteLine("Input the second number");
//string example2 = Console.ReadLine();
//int b = Convert.ToInt32(example2);
if (a%7 == 0 && a%23 == 0)
    Console.WriteLine("True");
else  
Console.WriteLine("False");  
