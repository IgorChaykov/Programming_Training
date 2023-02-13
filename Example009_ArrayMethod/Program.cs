int Max (int x, int y, int z)
{
    int result = x;
    if (y > result) result = y;
    if (z > result) result = z;
    return result;
}
int[] Array = { 64, 54, 26, 24, 55, 65, 72, 35, 15 };

int max = Max (Max (Array[0], Array[1], Array[2]), Max (Array[3], Array[4], Array[5]), Max (Array[6], Array[7], Array[8]));
Console.WriteLine(max);
