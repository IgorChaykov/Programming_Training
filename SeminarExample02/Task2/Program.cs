Random Number = new Random();
int number = Number.Next(100, 1000);
Console.WriteLine($"{number}");
int a = number/100;
int b = number%10;
Console.WriteLine($"{a}{b}");
