﻿Random random = new();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
    PlayGame();

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target = random.Next(1, 6);
        var roll = random.Next(1, 7);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay() => (Console.ReadLine() ?? "").ToUpper() == "Y";
string WinOrLose(int roll, int target) => $"You {(roll > target ? "win" : "lose")}!";
