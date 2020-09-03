using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodeDecodeString
{
    class Program
    {
        static void Main(string[] args)
        {
            bool EncodeDecode = true;
            while (EncodeDecode)
            {
                Console.WriteLine();
                Console.WriteLine("Type 'encode' for encode or 'decode' for decode: ");
                string encodeDecode = Console.ReadLine();

                if (encodeDecode == "encode")
                {
                    Console.Write("Please enter a string to encode: ");
                    string entry = Console.ReadLine();
                    string encoded = "";

                    entry = entry.ToLower();

                    foreach (char c in entry)
                    {
                        foreach (KeyValuePair<char, char> letter in codes)
                        {
                            if (letter.Key == c)
                            {
                                encoded += letter.Value;
                            }
                        }
                    }
                    Console.WriteLine("Encoded string: " + encoded);


                }
                else if (encodeDecode == "decode")
                {
                    Console.Write("Please enter a string to decode: ");
                    string entry = Console.ReadLine();
                    string decoded = "";

                    foreach (char c in entry)
                    {
                        foreach (KeyValuePair<char, char> letter in codes)
                        {
                            if (letter.Value == c)
                                decoded += letter.Key;
                        }
                    }
                    Console.WriteLine("Decoded string: " + decoded);

                    Console.ReadKey();
                    return;
                }
                else
                    Console.WriteLine("Please enter 'encode' or 'decode'");
            }
        }
        public static Dictionary<char, char> codes = new Dictionary<char, char>()
        {
            { 'a', 'z' },
            { 'b', 'y' },
            { 'c', 'x' },
            { 'd', 'w' },
            { 'e', 'v' },
            { 'f', 'u' },
            { 'g', 't' },
            { 'h', 's' },
            { 'i', 'r' },
            { 'j', 'q' },
            { 'k', 'p' },
            { 'l', 'o' },
            { 'm', 'n' },
            { 'n', 'm' },
            { 'o', 'l' },
            { 'p', 'k' },
            { 'q', 'j' },
            { 'r', 'i' },
            { 's', 'h' },
            { 't', 'g' },
            { 'u', 'f' },
            { 'v', 'e' },
            { 'w', 'd' },
            { 'x', 'c' },
            { 'y', 'b' },
            { 'z', 'a' },
        };
    }
}


