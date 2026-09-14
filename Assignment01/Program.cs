namespace Assignment01
// ชื่อ-นามสกุล: ธัญพิสิษฐ์ จันทร์แจ่ม
//Section: 129C
//รหัสนักศึกษา: 1690702244
//ลขที่: N/A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "Shadow Adventure";

            var playerName = "Zero";
            var playerRank = 'A';

            int playerLevel = 25;
            float critChance = 35.5f;
            double stamina = 89.6;
            bool isPlayable = true;

            Console.WriteLine("================================");
            Console.WriteLine($"        {GameTitle}");
            Console.WriteLine("================================");
            Console.WriteLine($" Player Name  : {playerName}");
            Console.WriteLine($" Rank         : {playerRank}");
            Console.WriteLine($" Level        : {playerLevel}");
            Console.WriteLine($" Crit Chance  : {critChance}%");
            Console.WriteLine($" Stamina      : {stamina}");
            Console.WriteLine($" Playable     : {isPlayable}");
            Console.WriteLine("================================");

            // Implicit Conversion
            double levelAsDouble = playerLevel;

            Console.WriteLine();
            Console.WriteLine("----- Conversion Test -----");
            Console.WriteLine($"Level as Double : {levelAsDouble}");

            // Explicit Cast
            int staminaCast = (int)stamina;

            // Convert.ToInt32
            int staminaConvert = Convert.ToInt32(stamina);

            Console.WriteLine($"Stamina Cast    : {staminaCast}");
            Console.WriteLine($"Stamina Convert : {staminaConvert}");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            Console.WriteLine("Hello, World!");
        }
    }
}