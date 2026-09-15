namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Game title, Sub-title
            Console.WriteLine("===>> MY GAME DEE <<==");
            Console.WriteLine("Hero vs Monster, Fight damage calulator\n");

            //Hero stats input
            Console.Write("Hero Health: ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHP);
            Console.Write("Hero Attack: ");
            bool heroAtkOk = int.TryParse(Console.ReadLine(), out int heroATK);
            Console.Write("Hero Defense: ");
            bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDEF);

            //Monster stats input
            Console.Write("Monster Health: ");
            bool monHpOk = int.TryParse(Console.ReadLine(), out int monHP);
            Console.Write("Monster Attack: ");
            bool monAtkOk = int.TryParse(Console.ReadLine(), out int monAtk);
            Console.Write("Monster Defense: ");
            bool monDefOk = int.TryParse(Console.ReadLine(), out int monDEF);

            //Input validation
            bool isHeroInValid = heroHpOk && heroAtkOk && heroDefOk;
            bool isMonsterInValid = monHpOk && monAtkOk && monDefOk;
            Console.WriteLine($"\nHERO STATUS VALID: {isHeroInValid}");
            Console.WriteLine($"MONSTER STATUS VALID: {isMonsterInValid}");

            Console.WriteLine($"[HERO         HP: {heroHP} | ATK: {heroATK} | DEF: {heroDEF}]");
            Console.WriteLine($"[MONSTER      HP: {monHP} | ATK: {monAtk} | DEF: {monDEF}]\n");


            // Compond assignment : +=
            int potionHeal = 8;
            heroHP += potionHeal;
            Console.WriteLine($"\nHERO drinks a potion, healing {potionHeal} HP. HERO HP : {heroHP} HP");



            // Arithmetic + ตีธรรมดา
            int normalDamage = Math.Max(0, heroATK - monDEF);
            Console.WriteLine($"\nNormal Attack wonld deal: {normalDamage} damage");

            // Precedence ตีพิเศษ
            int pwrDmg = Math.Max(0, heroATK * 2 - monDEF);
            Console.WriteLine($"\nPower Attack wonld deal: {pwrDmg} damage");


            // Random, Simple percent of critical chane
            Random randomSomething = new Random();
            int roll = randomSomething.Next(1, 101);
            bool isCrit = roll <= 10; // 10% chance จาก 10
            int critDmg = normalDamage + Convert.ToInt32(isCrit) * normalDamage;
            Console.WriteLine($"\nCritical hit roll: {roll} (critical: {isCrit}");
            Console.WriteLine($"If cirical, normal attack would instead deal: {critDmg} damage");


        }
    }
}
