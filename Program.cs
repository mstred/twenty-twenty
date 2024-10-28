string pangram = "The quick brown fox jumps over the lazy dog";

string[] words = pangram.Split(" ");
string[] reversedWords = new string[words.Length];
int index = 0;

foreach (var word in words)
{
    char[] letters = word.ToCharArray();
    Array.Reverse(letters);

    reversedWords[index++] = new string(letters);
}

string output = String.Join(" ", reversedWords);

Console.WriteLine(output);
