// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Вид 1
void Method1()
{
    Console.WriteLine("како-то текст");
}
Method1();

//Вид 2
void Method2(string msg)
{
    System.Console.WriteLine(msg);
}
Method2(msg: "опять какой-то текст");

//Вид 2.1
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "снова какой-то текст", count: 4);
Method21(count: 4, msg: "текст какой-то снова");

// Вид 3

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
System.Console.WriteLine(year);

//Вид 4

string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "все еще текст ");
System.Console.WriteLine(res);

//Вид 4.1

string Method41(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res1 = Method41(5, "текст, но через for ");
System.Console.WriteLine(res1);
//Таблица умножения

for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {

        System.Console.Write($"{i}x{j}={i * j}  ");
        //System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
