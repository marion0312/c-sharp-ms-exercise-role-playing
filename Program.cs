var heroHP = 10;
var monsterHP = 10;
var currentTurn = "hero";
Random randomAtk = new();
var dmg = 0;

do {
    dmg = randomAtk.Next(1, 11);
    if (currentTurn == "hero") {
        monsterHP -= dmg;
        System.Console.WriteLine($"Monster was damaged and lost {dmg} health and now has {monsterHP} health.");
        currentTurn = "monster";
    } else {
        heroHP -= dmg;
        currentTurn = "hero";
        System.Console.WriteLine($"Hero was damaged and lost {dmg} health and now has {heroHP} health.");
    }

} while ( heroHP >= 0 && monsterHP >= 0 );

if (heroHP <= 0) 
    System.Console.WriteLine("Monster wins!");
else
    System.Console.WriteLine("Hero wins!");