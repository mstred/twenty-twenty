string permission = "Admin|Manager";
int level = 56;

string message;

if (permission.Contains("Admin") && level > 55)
{
    message = "Welcome, Super Admin user.";
}
else if (permission.Contains("Admin") && level <= 55)
{
    message = "Welcome, Admin user.";
}
else if (permission.Contains("Manager") && level >= 20)
{
    message = "Contact an Admin for access.";
}
else if (permission.Contains("Manager") && level < 20)
{
    message = "You do not have sufficient privileges.";
}
else
{
    message = "You do not have sufficient privileges.";
}

Console.WriteLine(message);
