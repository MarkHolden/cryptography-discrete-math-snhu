namespace Cryptography
{
    public class Decrypt
    {
        const int D = 7;
        const int N = 33;

        public static void Run()
        {
            Console.WriteLine("Enter a phrase to decrypt:");
            var input = Console.ReadLine();
            if (input != null)
            {
                var plainText = new List<int>();
                Console.WriteLine("Unencrypted:");
                foreach (var value in input.Split(' '))
                {
                    var digit = int.Parse(value);
                    var unencrypted = (int)(Math.Pow(digit, D) % N);
                    plainText.Add(unencrypted);
                    Console.Write(string.Format("{0:00}", unencrypted) + " ");
                }                
                
                var message = "";
                foreach (var value in plainText)
                {
                    message += Conversion.GetChar(value);
                }

                Console.WriteLine($"\nMessage:\n{message}");
            }
        }
    }
}
