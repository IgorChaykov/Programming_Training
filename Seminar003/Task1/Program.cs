// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int[] points = new int[2];
for (int i = 0; i < points.Length; i++)
{
    points[i] = Convert.ToInt32(Console.ReadLine());
}
if (points[0] > 0 && points[1] > 0)
        Console.WriteLine("1");
else if (points[0] < 0 && points[1] < 0)


