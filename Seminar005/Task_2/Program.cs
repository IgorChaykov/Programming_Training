// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
void Rand()
{
    int[] arr = new int[6];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(-10, 11);
        System.Console.Write($"{arr[i]}\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
        System.Console.Write($"{arr[i]}\t");
    }
}
int Prompt(string mess)//метод ввода числа с клавиатуры
{
    System.Console.WriteLine(mess);
    int rez = Convert.ToInt32(Console.ReadLine());
    return rez;
}

void Task_33()
{
    int[] arr = new int[16];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(-100, 101);
        System.Console.Write($"{arr[i]}\t");

    }
  //  int[] arr = { 6, 7, 19, 345, 3};
System.Console.WriteLine();
int count = Prompt("Введите число для проверки");
foreach (int item in arr)


{
    if (item == count)
    {
        System.Console.WriteLine($"{count} есть в данном массиве");
        
    }   

   
}
System.Console.WriteLine("число не найдено");
}
Task_33();
