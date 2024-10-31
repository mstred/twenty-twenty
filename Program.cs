// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf("(") + 1;
// int closingPosition = message.IndexOf(")");

// // Console.WriteLine(openingPosition);
// // Console.WriteLine(closingPosition);

// Console.WriteLine(message.Substring(openingPosition, closingPosition - openingPosition));

// string message = "What is the value <span>between the tags</span>?";

// int openingPosition = message.IndexOf("<span>") + 6;
// int closingPosition = message.IndexOf("</span>");

// Console.WriteLine(message.Substring(openingPosition, closingPosition - openingPosition));

string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan) + openSpan.Length;
int closingPosition = message.IndexOf(closeSpan);

Console.WriteLine(message.Substring(openingPosition, closingPosition - openingPosition));
