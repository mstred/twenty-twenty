var attack = new Random();
var heroHealth = 10;
var monsterHealth = 10;

while (heroHealth > 0 || monsterHealth > 0)
{
    var heroAttack = attack.Next(1, 11);
    monsterHealth -= heroAttack;

    Console.WriteLine($"Monster was damaged and lost {heroAttack} and now has {monsterHealth}.");

    if (monsterHealth <= 0)
        break;

    var monsterAttack = attack.Next(1, 11);
    heroHealth -= monsterAttack;

    Console.WriteLine($"Hero was damaged and lost {monsterAttack} and now has {heroHealth}.");
}

Console.WriteLine($"{((heroHealth > monsterHealth) ? "Hero" : "Monster")} wins!");
