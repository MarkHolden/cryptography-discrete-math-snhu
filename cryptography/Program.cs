const int E = 3;
const int N = 33;

Console.WriteLine("Enter a phrase to encrypt:");
var input = Console.ReadLine();
if (input != null)
{
    var plainText = new List<int>();
    foreach(var character in input.ToLower())
    {
        plainText.Add(Conversion.Table[character]);
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

public class Conversion
{
    public static Dictionary<char, int> Table = new Dictionary<char, int>
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
        { ' ', 32 },
        { '.', 33 },
        { ',', 34 },
        { '!', 35 },
        { '?', 36 },
        { '(', 37 },
        { ')', 38 }
    };
}