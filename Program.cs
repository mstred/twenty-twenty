// Code project 1
/*
Console.WriteLine("Enter an integer value between 5 and 10");

bool notInRange;
int output;

do 
{
    string? input = Console.ReadLine();
    var notValid = !int.TryParse(input, out output);

    notInRange = !(output >= 5 && output <= 10);

    if (notValid)
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    else if (notInRange)
        Console.WriteLine($"You entered {output}. Please enter a number between 5 and 10.");
} while (notInRange);

Console.WriteLine($"Your input value ({output}) has been accepted.");
*/

// Code project 2
/*
Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

string[] acceptableRoles = ["administrator", "manager", "user"];
string? role = null;
bool notAccepted = true;

while (notAccepted)
{
    role = Console.ReadLine()?.Trim();
    notAccepted = !acceptableRoles.Contains(role?.ToLower());

    if (notAccepted)
        Console.WriteLine($"The role name that you entered, \"{role}\" is not valid. Enter your role name (Administrator, Manager, or User)");
}

Console.WriteLine($"Your input value ({role}) has been accepted.");
*/

// Code project 3

// string[] myStrings = ["I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"];

// int periodLocation = 0;

// foreach (var item in myStrings)
// {
//     var myString = item;

//     while (periodLocation != -1)
//     {
//         myString = myString.TrimStart();
//         periodLocation = myString.IndexOf('.');

//         if (periodLocation == -1)
//             break;

//         var tempString = myString[..periodLocation];
//         Console.WriteLine(tempString);

//         myString = myString.Remove(0, periodLocation + 1);
//     }

//     Console.WriteLine(myString);
// }
