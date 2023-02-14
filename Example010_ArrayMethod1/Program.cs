int[] Array = { 6, 5, 19, 75, 26, 62, 49, 22 };

int n = Array.Length;
int find = 49;

int index = 0;

while ( index < n )
{
    
    if(Array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
