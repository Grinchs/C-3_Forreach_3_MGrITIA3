using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_3_Forreach_3_MGrITIA3
{
    internal class Program
    {
        //https://gist.github.com/iomoath/ff2416f658a1b394978aff1735c89adc ņēmu šito kā piemēru

        static Dictionary<char, string> morseAlphabet = new Dictionary<char, string>()
        {
            {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."}, {'E', "."}, {'F', "..-."},
            {'G', "--."}, {'H', "...."}, {'I', ".."}, {'J', ".---"}, {'K', "-.-"}, {'L', ".-.."},
            {'M', "--"}, {'N', "-."}, {'O', "---"}, {'P', ".--."}, {'Q', "--.-"}, {'R', ".-."},
            {'S', "..."}, {'T', "-"}, {'U', "..-"}, {'V', "...-"}, {'W', ".--"}, {'X', "-..-"},
            {'Y', "-.--"}, {'Z', "--.."}, {'0', "-----"}, {'1', ".----"}, {'2', "..---"}, {'3', "...--"},
            {'4', "....-"}, {'5', "....."}, {'6', "-...."}, {'7', "--..."}, {'8', "---.."}, {'9', "----."},
            {'.', ".-.-.-"}, {',', "--..--"}, {'?', "..--.."}, {'\'', ".----."}, {'!', "-.-.--"}, {'/', "-..-."},
            {'(', "-.--."}, {')', "-.--.-"}, {'&', ".-..."}, {':', "---..."}, {';', "-.-.-."}, {'=', "-...-"},
            {'+', ".-.-."}, {'-', "-....-"}, {'_', "..--.-"}, {'\"', ".-..-."}, {'$', "...-..-"}, {'@', ".--.-."},
            {' ', "/"}
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Ievadiet tekstu:");
            string inputs = Console.ReadLine();

            // Pārveido tekstu kodā
            string morseText = ConvertToMorse(inputs);

            Play(morseText);
        }

        static string ConvertToMorse(string text)
        {
            string morseTexts = "";
            foreach (char c in text.ToUpper())
            {
                // Meklē burtus dictionarijā un pievieno parveidojumu
                if (morseAlphabet.ContainsKey(c))
                {
                    morseTexts += morseAlphabet[c] + " ";
                }
                else
                {
                    // Lai nekas nesačakarētos, simbolus kas nav dictionarijā pārveido par tukšumu
                    morseTexts += " ";
                }
            }
            return morseTexts;
        }

        // Atskaņo visu
        static void Play(string morseText)
        {
            foreach (char c in morseText)
            {
                if (c == '.')
                {
                    Console.Beep(1000, 100);
                }
                else if (c == '-')
                {
                    Console.Beep(1000, 800);
                }
                else if (c == ' ')
                {
                    Thread.Sleep(100);
                }
            }
        }
    }
}