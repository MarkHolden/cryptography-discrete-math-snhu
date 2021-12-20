namespace Cryptography
{
    public class Program
    {
        public static void Main()
        {
            var exit = false;
            while(!exit)
            {
                Console.WriteLine("Press E to Encrypt, D to Decrypt, and Q to quit.");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "E":
                    case "e":
                        Encrypt.Run();
                        break;
                    case "Q":
                    case "q":
                        exit = true;
                        break;
                    case "D":
                    case "d":
                        Decrypt.Run();
                        break;
                    default:
                        Console.WriteLine("Invalid Entry.");
                        break;
                }
            }
        }
    }
    public class Conversion
    {
        public static int GetInt(char lookup)
        {
            return table[lookup];
        }
        public static char GetChar(int lookup)
        {
            return table.FirstOrDefault(t => t.Value == lookup).Key;
        }

        private static Dictionary<char, int> table = new Dictionary<char, int>
        {
            { 'a', 1 },
            { 'b', 2 },
            { 'c', 3 },
            { 'd', 4 },
            { 'e', 5 },
            { 'f', 6 },
            { 'g', 7 },
            { 'h', 8 },
            { 'i', 9 },
            { 'j', 10 },
            { 'k', 11 },
            { 'l', 12 },
            { 'm', 13 },
            { 'n', 14 },
            { 'o', 15 },
            { 'p', 16 },
            { 'q', 17 },
            { 'r', 18 },
            { 's', 19 },
            { 't', 20 },
            { 'u', 21 },
            { 'v', 22 },
            { 'w', 23 },
            { 'x', 24 },
            { 'y', 25 },
            { 'z', 26 },
            { '.', 27 },
            { ',', 28 },
            { '!', 29 },
            { '\'', 30 },
            { ' ', 32 }
        };
    }
}