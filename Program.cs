string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

string topMessage = @$"Dear {customerName},
As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.

Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.
";

Console.WriteLine(topMessage);
Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";
comparisonMessage += $"{currentProduct.PadRight(20)}";
comparisonMessage += $"{string.Format("{0:P}", currentReturn).PadRight(10)}";
comparisonMessage += $"{string.Format("{0:C}", currentProfit).PadRight(10)}\n";
comparisonMessage += $"{newProduct.PadRight(20)}";
comparisonMessage += $"{string.Format("{0:P}", newReturn).PadRight(10)}";
comparisonMessage += $"{string.Format("{0:C}", newProfit).PadRight(10)}\n";

Console.WriteLine(comparisonMessage);
