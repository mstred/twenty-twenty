﻿string ReverseWord(string word)
{
    string result = "";

    for (int i = word.Length - 1; i >= 0; i--)
        result += word[i];

    return result;
}

string input = "there are snakes in the zoo";

Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));

string ReverseSentence(string input)
{
    string result = "";
    string[] words = input.Split(" ");

    foreach (string word in words)
        result += $"{ReverseWord(word)} ";

    return result.Trim();
}
