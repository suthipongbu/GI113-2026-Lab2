// Student ID: 1690704224
// Name: สุธิพงษ์ ชาวนาแฝง
// Section: -
// No.: -

using System;

// ==================== Part A ====================

string bossName = "Kirin";
char rank = 'S';
int level = 7;
int maxHp = 240;
int currentHp = 175;
float attackPower = 42.5f;
double critMultiplier = 1.75;
bool isBoss = true;

Console.WriteLine("===== BOSS STATUS: INITIAL =====");
Console.WriteLine($"Name: {bossName}");
Console.WriteLine($"Rank: {rank}");
Console.WriteLine($"Level: {level}");
Console.WriteLine($"HP: {currentHp} / {maxHp}");
Console.WriteLine($"Attack Power: {attackPower}");
Console.WriteLine($"Crit Multiplier: {critMultiplier}");
Console.WriteLine($"Is Boss: {isBoss}");

Console.WriteLine();

int hpPercent = currentHp * 100 / maxHp;
Console.WriteLine($"HP Percent: {hpPercent}%");

Console.WriteLine();

Console.WriteLine($"{bossName} takes 60 damage!");
currentHp = currentHp - 60;

Console.WriteLine();

Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
Console.WriteLine($"HP: {currentHp} / {maxHp}");

hpPercent = currentHp * 100 / maxHp;
Console.WriteLine($"HP Percent: {hpPercent}%");

// ==================== Part B ====================

string heroName = "Arin";
int heroHp = 180;
double heroSpeed = 12.5;
char heroRank = 'A';
bool heroAlive = true;

string mageName = "Luna";
int mageHp = 120;
double mageMana = 95.5;
float magePower = 38.5f;
char mageRank = 'B';

string warriorName = "Rex";
int warriorHp = 250;
float warriorAttack = 55.5f;
double warriorDefense = 30.25;
bool warriorAlive = true;
char warriorRank = 'S';

string healerName = "Mira";
int healerHp = 140;
double healerHealPower = 72.75;
float healerSpeed = 8.5f;
bool healerAlive = true;
char healerRank = 'A';

Console.WriteLine($"Name: {heroName}");
Console.WriteLine($"HP: {heroHp}");
Console.WriteLine($"Speed: {heroSpeed}");
Console.WriteLine($"Rank: {heroRank}");
Console.WriteLine($"Alive: {heroAlive}");

Console.WriteLine($"Name: {mageName}");
Console.WriteLine($"HP: {mageHp}");
Console.WriteLine($"Mana: {mageMana}");
Console.WriteLine($"Power: {magePower}");
Console.WriteLine($"Rank: {mageRank}");

Console.WriteLine($"Name: {warriorName}");
Console.WriteLine($"HP: {warriorHp}");
Console.WriteLine($"Attack: {warriorAttack}");
Console.WriteLine($"Defense: {warriorDefense}");
Console.WriteLine($"Alive: {warriorAlive}");
Console.WriteLine($"Rank: {warriorRank}");

Console.WriteLine($"Name: {healerName}");
Console.WriteLine($"HP: {healerHp}");
Console.WriteLine($"Heal Power: {healerHealPower}");
Console.WriteLine($"Speed: {healerSpeed}");
Console.WriteLine($"Alive: {healerAlive}");
Console.WriteLine($"Rank: {healerRank}");
