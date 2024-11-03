const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

int spanContentIndex = input.IndexOf("<span>") + 6;

quantity = input.Substring(spanContentIndex, input.IndexOf("</span>") - spanContentIndex);
output = input.Replace("&trade;", "&reg;").Replace("<div>", "").Replace("</div>", "");

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");
