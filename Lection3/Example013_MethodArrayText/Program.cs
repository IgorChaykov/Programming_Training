﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i<length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replase(text, ' ', '|');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replase(text, 'к', 'К');
System.Console.WriteLine(newText);
