namespace Cryptography
{
    public static class Encrypt
    {
        const int E = 3;
        const int N = 33;

        public static void Run()
        {
            Console.WriteLine("Enter a phrase to encrypt:");
            var input = Console.ReadLine();
            if (input != null)
            {
                var plainText = new List<int>();
                foreach (var character in input.ToLower())
                {
                    plainText.Add(Conversion.GetInt(character));
                }

                Console.WriteLine("Unencrypted:");
                var cypherText = new List<int>();
                foreach (var value in plainText)
                {
                    Console.Write(string.Format("{0:00}", value) + " ");
                    cypherText.Add((int)Math.Pow(value, E) % N);
                }

                Console.WriteLine("\nEncrypted:");
                foreach (var value in cypherText)
                {
                    Console.Write(string.Format("{0:00}", value) + " ");
                }
            }
        }
    }
}
