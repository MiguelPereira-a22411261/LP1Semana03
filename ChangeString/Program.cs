using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string str, chr, endStr;
            char convertChar;
            Console.Write("Insert a string: ");
            str = Console.ReadLine();
            Console.Write("Insert a character: ");
            chr = Console.ReadLine();

            endStr = "";
            convertChar = char.Parse(chr);

            foreach (char chr2 in str)
            {
                if (chr2 == convertChar)
                {
                    endStr += 'x';
                }
                else
                {
                    endStr += chr2;
                }
            }
            Console.WriteLine(endStr);
        }
    }
}
