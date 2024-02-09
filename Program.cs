namespace CaesarCypher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Enter the text to be encrypted: ");
            string? input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("Please enter a valid input");
                return;
            }

            Console.WriteLine("Enter the key: ");
            int key = Convert.ToInt32(Console.ReadLine());
            if (key < 0)
            {
                Console.WriteLine("Please enter a valid key");
                return;
            }
            
            if (typeof(string) != input.GetType() || typeof(int) != key.GetType())
            {
                Console.WriteLine("Please enter a valid input");
                return;
            }

            if (key > 26)
            {
                key %= 26;
            }
            
            Console.WriteLine("Encrypted text: " + Encrypt(input, key));
            Console.WriteLine("Decrypted text: " + Decrypt(Encrypt(input, key), key));

            Environment.Exit(0);
        }

        static string Encrypt(string input, int key)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (char.IsLetter(c))
                {
                    if (char.IsUpper(c))
                    {
                        output += (char)((((c + key) - 65) % 26) + 65);
                    }
                    else
                    {
                        output += (char)((((c + key) - 97) % 26) + 97);
                    }
                }
                else
                {
                    output += c;
                }
            }
            return output;
        }

        static string Decrypt(string input, int key)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (char.IsLetter(c))
                {
                    if (char.IsUpper(c))
                    {
                        output += (char)((((c - key) - 65 + 26) % 26) + 65);
                    }
                    else
                    {
                        output += (char)((((c - key) - 97 + 26) % 26) + 97);
                    }
                }
                else
                {
                    output += c;
                }
            }
            return output;
        }
    }
}