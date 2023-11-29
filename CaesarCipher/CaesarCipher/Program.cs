using System;

/*
Caesar Cipher
By 6 a.m. on Sunday, your team’s project is nearly finished. The Object of Your Affection (the name’s a work in progress) is getting attention from other teams in the hackathon. With one day left, they’re getting desperate. To steal your project idea, your competitors have been reading your team’s emails!

As the team’s C# expert, you have been asked to write a cipher: a tool to encrypt text, making it unreadable to other teams. You’ve decided to implement the Caesar Cipher, which was used by the Roman Empire to encode military secrets.

To use the cipher, draw the alphabet in a circle like so
Take every letter of your message and shift it three places to the right. For example, A becomes D, B becomes E, C becomes F, and “attack” becomes “dwwdfn”.
*/

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter te message: ");
            string message = Console.ReadLine();
            message = message.ToLower();
            char[] secretMessage = message.ToCharArray();

            Console.Write("You want to Encrypt or Decrypt the message(E/D): ");
            string choice = Console.ReadLine();
            choice = choice.ToUpper();

            Console.Write("Enter the key: ");
            int key = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case "E":
                    Console.WriteLine(Encrypt(secretMessage, key));
                    break;
                case "D":
                    Console.WriteLine(Decrypt(secretMessage, key));
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
        static string Encrypt(char[] secretMessage, int key)
        {

            int length = secretMessage.Length;
            char[] encryptedMessage = new char[length];

            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int i = 0; i < length; i++)
            {
                char letter = secretMessage[i];
                if (Char.IsLetter(letter))
                {
                    int posInAlphabet = Array.IndexOf(alphabet, letter);
                    int newPos = (posInAlphabet + key) % alphabet.Length;
                    char encryptedLetter = alphabet[newPos];
                    encryptedMessage[i] = encryptedLetter;
                }
                else
                {
                    encryptedMessage[i] = letter;
                }
            }
            string finallMessage = String.Join("", encryptedMessage);
            return finallMessage;
        }
        static string Decrypt(char[] secretMessage, int key)
        {

            int length = secretMessage.Length;
            char[] DecryptedMessage = new char[length];

            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int i = 0; i < length; i++)
            {
                char letter = secretMessage[i];
                if (Char.IsLetter(letter))
                {
                    int posInAlphabet = Array.IndexOf(alphabet, letter);
                    int newPos = (posInAlphabet - key) % alphabet.Length;
                    char DecryptedLetter = alphabet[newPos];
                    DecryptedMessage[i] = DecryptedLetter;
                }
                else
                {
                    DecryptedMessage[i] = letter;
                }
            }
            string finallMessage = String.Join("", DecryptedMessage);
            return finallMessage;
        }
    }
}