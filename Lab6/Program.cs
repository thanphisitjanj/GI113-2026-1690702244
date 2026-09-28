namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int heroHp;
            int heroAttack;
            int monsterHp;
            int monsterAttack;
            int choice;
            Console.WriteLine("Enter Hero HP: ");
            while (!int.TryParse(Console.ReadLine(), out heroHp) || heroHp <= 0)
            {
                Console.WriteLine("Invalid input. Enter Hero HP: ");
            }
            Console.Write("Enter Hero Attack: ");
            while (!int.TryParse(Console.ReadLine(), out heroAttack))
            {
                Console.WriteLine("Invalid input. Enter Hero Attack: ");
            }
            Console.WriteLine("Enter Monster HP: ");
            while (!int.TryParse(Console.ReadLine(), out monsterHp))
            {
                Console.WriteLine("Invalid input. Enter Monster HP: ");
            }
            Console.WriteLine("Enter Monster Attack: ");
            while (!int.TryParse(Console.ReadLine(), out monsterAttack))
            {
                Console.WriteLine("Invalid input. Enter Monster Attack: ");
            }
            Console.WriteLine();
            Console.WriteLine("Choose your action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Use Skill");
            Console.WriteLine("3. Run");
            Console.Write("Choice: ");
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid input. Enter a valid choice: ");
            }
            Console.WriteLine();
            if (choice == 1)
            {
                Console.WriteLine("Hero attacks the monster.");
                monsterHp -= heroAttack;
                if (monsterHp <= 0)
                {
                    Console.WriteLine("Hero attacks and defeats the monster!");
                }
                else
                {
                    heroHp -= monsterAttack;
                    Console.WriteLine("The Monster attacks back.");
                    Console.WriteLine("One round is over.");
                }
            }
            else if (choice == 2)
            {
                monsterHp -= heroAttack * 2;
                if (monsterHp <= 0)
                {
                    Console.WriteLine("Hero uses a powerful skill and defeats the Moster!");
                }
            }
            else
            {
                heroHp -= monsterAttack;
                Console.WriteLine("Hero uses a skill.");
                Console.WriteLine("The Monster attacks while hero runs away.");
                Console.WriteLine("One round is over.");
            }
        }
    }
}