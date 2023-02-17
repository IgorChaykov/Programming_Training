// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter number: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

//int[] array = new int[4] ;
for (int i = 1;i<=number;i++ )
{
    Console.WriteLine(i*i);
}
