﻿string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    // display internal email addresses
    DisplayEmailAddress(firstName: corporate[i, 0], lastName: corporate[i, 1]);
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    // display external email addresses
    DisplayEmailAddress(firstName: external[i, 0], lastName: external[i, 1], domain: externalDomain);
}

void DisplayEmailAddress(string firstName, string lastName, string domain = "contoso.com")
{
    Console.WriteLine($"{firstName.ToLower()[..2]}{lastName.ToLower()}@{domain}");
}
