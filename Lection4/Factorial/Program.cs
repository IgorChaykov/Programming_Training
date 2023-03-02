// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

double Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);

}
// System.Console.WriteLine(Factorial(4));
for (int i = 1; i < 40; i++)
{
    System.Console.WriteLine($"!{i}={Factorial(i)}");
}
int Fibonacci(int n)
{
    if(n==1 || n==2) return 1;
    else return Fibonacci(n-1)+Fibonacci(n-2);

}
for (int i = 1; i<10; i++)
{
    System.Console.WriteLine(Fibonacci(i));
}