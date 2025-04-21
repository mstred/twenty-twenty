// Prompt the user for the lower and upper bounds
Console.Write("Enter the lower bound: ");
int lowerBound = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Enter the upper bound: ");
int upperBound = int.Parse(Console.ReadLine() ?? "0");

bool exit;

do
{
    try
    {
        // Calculate the sum of the even numbers between the bounds
        decimal averageValue = AverageOfEvenNumbers(lowerBound, upperBound);
        // Display the value returned by AverageOfEvenNumbers in the console
        Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");
        exit = true;
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine($"An error has occurred.\n{ex.Message}\nThe upper bound must be greater than {lowerBound}");

        Console.Write($"Enter a new upper bound (or enter Exit to quit): ");
        string? userResponse = (Console.ReadLine() ?? "").ToLower();
        exit = userResponse.Contains("exit");

        if (!exit)
            upperBound = int.Parse(userResponse);
    } 
} while (!exit);

static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
{
    if (lowerBound >= upperBound)
        throw new ArgumentOutOfRangeException("upperBound", "ArgumentOutOfRangeException: upper bound must be greater than the lower bound.");

    int sum = 0;
    int count = 0;
    decimal average = 0;

    for (int i = lowerBound; i <= upperBound; i++)
    {
        if (i % 2 == 0)
        {
            sum += i;
            count++;
        }
    }

    average = (decimal)sum / count;

    return average;
}
