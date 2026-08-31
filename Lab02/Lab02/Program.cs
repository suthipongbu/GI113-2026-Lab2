// Student ID: 1690704224
// Name: สุธิพงษ์ ชาวนาแปน
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
char mageRank = 'S';
bool mageAlive = true;

string warriorName = "Rex";
int warriorHp = 250;
float warriorAttack = 55.5f;
char warriorRank = 'S';
bool warriorAlive = true;

string healerName = "Mira";
int healerHp = 140;
float healerSpeed = 8.5f;
char healerRank = 'A';
bool healerAlive = true;

Console.WriteLine($"Name: {heroName}");
Console.WriteLine($"HP: {heroHp}");
Console.WriteLine($"Speed: {heroSpeed}");
Console.WriteLine($"Rank: {heroRank}");
Console.WriteLine($"Alive: {heroAlive}");

Console.WriteLine($"Name: {mageName}");
Console.WriteLine($"HP: {mageHp}");
Console.WriteLine($"Mana: {mageMana}");
Console.WriteLine($"Rank: {mageRank}");
Console.WriteLine($"Alive: {mageAlive}");

Console.WriteLine($"Name: {warriorName}");
Console.WriteLine($"HP: {warriorHp}");
Console.WriteLine($"Attack: {warriorAttack}");
Console.WriteLine($"Rank: {warriorRank}");
Console.WriteLine($"Alive: {warriorAlive}");

Console.WriteLine($"Name: {healerName}");
Console.WriteLine($"HP: {healerHp}");
Console.WriteLine($"Speed: {healerSpeed}");
Console.WriteLine($"Rank: {healerRank}");
Console.WriteLine($"Alive: {healerAlive}");
