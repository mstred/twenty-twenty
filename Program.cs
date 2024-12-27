int[,] TwoCoins(int[] coins, int target)
{
    int[,] result = {{-1, -1}, {-1, -1}, {-1, -1}, {-1, -1}, {-1, -1}};
    int count = 0;

    for (int current = 0; current < coins.Length; current++)
        for (int next = current + 1; next < coins.Length; next++)
        {
            if (coins[current] + coins[next] == target)
            {
                result[count, 0] = current;
                result[count, 1] = next;
                count++;
            }
            if (count == result.GetLength(0))
                return result;
        }

    return (count == 0) ? new int[0, 0] : result;
}

int target = 80;
int[] coins = [5, 5, 50, 25, 25, 10, 5];
int[,] result = TwoCoins(coins, target);
int resultLength = result.GetLength(0);

if (resultLength == 0)
    Console.WriteLine("No two coins make change");
else
    Console.WriteLine("Change found at positions:");
    for (int i = 0; i < resultLength; i++)
    {
        int first = result[i, 0];
        int second = result[i, 1];
        if (first == -1 && second == -1)
            break;
        Console.WriteLine($"{first}, {second}");
    }
