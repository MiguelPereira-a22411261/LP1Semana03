using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string str, chr;
            char convertChar;
            Console.Write("Insert a string: ");
            str = Console.ReadLine();
            Console.Write("Insert a character: ");
            chr = Console.ReadLine();

            convertChar = char.Parse(chr);

            foreach (char chr2 in str)
            {
                if (chr2 == convertChar)
                {
                    convertChar = 'x';
                    Console.Write($"{convertChar}");
                }
                else
                {
                    Console.Write($"{chr2}");
                }
            }
        }
    }
}
