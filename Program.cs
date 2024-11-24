/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/

string[] ipv4Input = ["107.31.1.5", "255.0.0.255", "555..0.555", "255...255"];
bool validLength;
bool validZeroes;
bool validRange;

foreach (string ip in ipv4Input)
{
    ValidateLength(ip);
    ValidateZeroes(ip);
    ValidateRange(ip);

    if (validLength && validZeroes && validRange)
        Console.WriteLine($"ip is a valid IPv4 address");
    else
        Console.WriteLine($"ip is an invalid IPv4 address");
}

void ValidateLength(string ip)
{
    validLength = GetSplitAddress(ip).Length == 4;
}

void ValidateZeroes(string ip)
{
    foreach (string number in GetSplitAddress(ip))
    {
        validZeroes = !(number.Length > 1 && number.StartsWith('0'));
        if (!validZeroes)
            return;
    }

    validZeroes = true;
}

void ValidateRange(string ip)
{
    foreach (string number in GetSplitAddress(ip))
    {
        bool validParse = int.TryParse(number, out int value);
        if (!validParse || value < 0 || value > 255)
        {
            validRange = false;
            return;
        }
    }

    validRange = true;
}

string[] GetSplitAddress(string ip)
{
    return ip.Split('.', StringSplitOptions.RemoveEmptyEntries
                                & StringSplitOptions.TrimEntries);
}
