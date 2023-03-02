Console.Clear();
System.Console.WriteLine("1 - количество цифр в числе");
System.Console.WriteLine("2 - произведение чисел от 1 до N");
System.Console.WriteLine("3 - вывод массива из 8 эл-ов, заполненный 0 и 1");
int numberOfTask = Prompt("Введите номер задачи");

switch (numberOfTask)
{
    case 1:
    Console.Clear();
    Task_26();
    break;

    case 2:
    Console.Clear();
    Task_28();
    break;

    case 3:
    Console.Clear();
    Task_30();
    break;

    default:
    System.Console.WriteLine("задача не ясна");
    break;
}
 
int Prompt(string mess)//метод ввода числа с клавиатуры
{
    System.Console.WriteLine(mess);
    int rez = Convert.ToInt32(Console.ReadLine());
    return rez;
}

void CountOfNumber(int userNumber)
{
    char [] number = userNumber.ToString().ToCharArray();
    System.Console.WriteLine($"{number.Length}");
}

void Task_26()// подсчет количества цифр в числе
{
    int number = Prompt("Введите число для обработки");
    CountOfNumber(number);
}

int MultiPly(int userNumber)
{
    int rez = 1;
    for (int i = 1; i <= userNumber; i++)
    {
        rez *= i;
    }
    return rez;
}

void Task_28()
{
    int number = Prompt("Введите число для подсчета произведения");
    int rez = MultiPly(number);
    System.Console.WriteLine($"Произведение чисел от 1 до {number} = {rez}");
}


void Task_30()
{
    Random ran = new Random();
    int [] arr = new int [8];
    for (int i = 0; i < arr.Length; i++)
    {
       arr[i] = ran.Next(0,2);
    }
    string array = String.Join("  ", arr);
    System.Console.WriteLine(array);
}
