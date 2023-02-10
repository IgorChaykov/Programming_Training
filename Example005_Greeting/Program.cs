Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "игорь")
{
    Console.WriteLine("Здорова, братан!");
}
else
{
    Console.Write("Здравствуйте, ");
    Console.WriteLine(username);
}