int[] TwoCoins(int[] coins, int target)
{
    for (int current = 0; current < coins.Length; current++)
        for (int next = current + 1; next < coins.Length; next++)
            if (coins[current] + coins[next] == target)
                return [current, next];

    return [];
}

int target = 60;
int[] coins = [5, 5, 50, 25, 25, 10, 5];
int[] result = TwoCoins(coins, target);

if (result.Length == 0)
    Console.WriteLine("No two coins make change");
else
    Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");
