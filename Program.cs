
/*
 * Access Modifiers
    - Public vs Private
    - Bli litt kjent med de forskjellige typene og hva de gjør. 
 * Innkapsling (encapsulation) (eks get & set)
 * Overloads
 * Default values / Default parameters
 
 * Eksempel: Character-class
 * Se hva vi kan bruke av dette for å forbedre App og Game.
 */


using Undervisning_Emne_3;

int enemyCount = 5;
List<Character> enemies = new List<Character>();
for (int i = 0; i < enemyCount; i++)
{
    enemies.Add(new Character());
}

List<Character> bosses = new List<Character>
{
    new Character("Boss", "Bowser", 100, 100, 20),
    new Character("Boss", "Godric", 1000, 1000, 200),
};

var hero = new Character("Hero", "Link", 50, 50, 5);

//foreach (Character enemy in enemies)
//{
//    enemy.PrintInfo();
//}
//foreach (Character boss in bosses)
//{
//    boss.PrintInfo();
//}
//hero.PrintInfo();

bosses[1].TakeDamage(hero);
bosses[1].PrintInfo();
