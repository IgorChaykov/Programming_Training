// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int[,] arr = new int[3, 4];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(0, 3);
    }
}
