// string message = "hello there!";

// int first_h = message.IndexOf('h');
// int last_h = message.LastIndexOf('h');

// Console.WriteLine($"For the message '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}");

// string message = "(What if) I am (only interested) in the last (set of parentheses)?";

// int openingPosition = message.LastIndexOf('(') + 1;
// int closingPosition = message.LastIndexOf(')');

// Console.WriteLine(message.Substring(openingPosition, closingPosition - openingPosition));

// string message = "(What if) there are (more than) one (set of parentheses)?";

// while (true)
// {
//     int openingPosition = message.IndexOf('(') + 1;
//     int closingPosition = message.IndexOf(')');

//     if (int.IsNegative(openingPosition) || int.IsNegative(closingPosition))
//         break;

//     Console.WriteLine(message.Substring(openingPosition, closingPosition - openingPosition));

//     message = message.Substring(closingPosition + 1);
// }

// string message = "Help (find) the {opening symbols}";
// Console.WriteLine($"Searching THIS Message: {message}");
// char[] openSymbols = ['[', '{', '('];
// int startPosition = 5;
// int openingPosition = message.IndexOfAny(openSymbols);
// Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

// openingPosition = message.IndexOfAny(openSymbols, startPosition);
// Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");

string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

char[] openSymbols = ['[', '{', '('];

int closingPosition = default;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (int.IsNegative(openingPosition))
        break;

    string currentSymbol = message.Substring(openingPosition, 1);

    char matchingSymbol = default;

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    if (int.IsNegative(closingPosition))
        break;

    Console.WriteLine(message.Substring(openingPosition, closingPosition - openingPosition));
}
