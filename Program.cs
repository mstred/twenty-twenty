string[] guestList = ["Rebecca", "Nadia", "Noor", "Jonte"];
string[] rsvps = new string[10];
int count = 0;

RSVP("Rebecca", 1, "none", true);
RSVP("Nadia", 2, "Nuts", true);
RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false);
RSVP(name: "Tony", inviteOnly: true, allergies: "Jackfruit", partySize: 1);
RSVP("Noor", 4, "none", false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();

void RSVP(string name, int partySize, string allergies, bool inviteOnly)
{
    if (inviteOnly)
    {
        // search guestList before adding rsvp
        bool found = false;

        foreach (var guest in guestList)
        {
            if (guest.Equals(name))
            {
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine($"Sorry, {name} is not on the guest list");
            return;
        }
    }

    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}

void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");

    foreach (var rsvp in rsvps)
    {
        if (!string.IsNullOrEmpty(rsvp))
            Console.WriteLine(rsvp);
    }
}
