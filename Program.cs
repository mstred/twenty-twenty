try
{
    int num1 = int.MaxValue;
    int num2 = int.MaxValue;
    checked
    {
        int result = num1 + num2;
        Console.WriteLine("Result: " + result);
    }
}
catch (OverflowException ex)
{
    Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
}

try
{
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
    string str = null;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
    int length = str.Length;
    Console.WriteLine("String Length: " + length);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Error: The reference is null. " + ex.Message);
}

try
{
    int[] numbers = new int[5];
    numbers[5] = 10;
    Console.WriteLine("Number at index 5: " + numbers[5]);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Error: Index out of range. " + ex.Message);
}

try
{
    int num3 = 10;
    int num4 = 0;
    int result2 = num3 / num4;
    Console.WriteLine("Result: " + result2);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
}

Console.WriteLine("Exiting program.");
