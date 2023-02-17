// See https://aka.ms/new-console-template for more information
void Boom(int[] bah, int n)
{
int length = bah.Length - 1;

 while (0 <= length)
 {
     int len = n % 10;
     bah[length] = len;
     length--;
     n = n / 10;
}} 

Console.WriteLine("enter a five-digit number");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100000 || num <= 9999 )
{
    Console.WriteLine($"{num} not a five-digit numbe");
    
}
else 
{
    int[]ArrNum = new int[5];
    Boom(ArrNum, num);
    
    if (ArrNum[0] == ArrNum[4] && ArrNum[1] == ArrNum[3])
    {
        Console.WriteLine("This number is a palindrome");

    }
    else
    {
        Console.WriteLine("This number is not a palindrome");
    }

}
