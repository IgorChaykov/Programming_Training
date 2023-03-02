// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] arrayResult = new int[12];
int positive = 0, negative = 0;
int[] GetArray()
{
    int[] array = new int[12];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}
void SummArray(int[] array)
{
    foreach (int el in array)
    {
        if (el>0)
            positive += el;
        else negative += el;    
    }
}
void PrintResult(int[] array, int positive, int negative)
{
    System.Console.WriteLine($" Array result is {String.Join("|", array)}");
    // System.Console.WriteLine($" Positive sum is {positive} and negative sum is {negative}");
}
arrayResult = GetArray();
SummArray(arrayResult);
PrintResult(arrayResult, positive, negative);
System.Console.WriteLine($" Positive sum is {positive} and negative sum is {negative}");